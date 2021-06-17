using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LineLengthCheck
{
    public static class MainEngine
    {
        #region Private Fields

        private static readonly Encoding defaultEncoding = Encoding.Default;
        private static readonly string[] lineSplitter = new string[] { Environment.NewLine };
        private static readonly byte[] utf8Bom = new byte[] { 0xEF, 0xBB, 0xBF };

        #endregion

        #region Public Methods

        public static CheckResult[] Analyze(string directory, string filePattern, bool recursive, int limit, bool countInAscii)
        {
            var list = new List<CheckResult>();

            DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new DirectoryInfo(directory);
            }
            catch
            {
                throw;
            }

            try
            {
                foreach (FileInfo file in directoryInfo.EnumerateFiles(filePattern))
                {
                    string fileName;

                    try
                    {
                        fileName = file.FullName;
                    }
                    catch
                    {
                        throw;
                    }

                    try
                    {
                        list.AddRange(Analyze(fileName, limit, countInAscii));
                    }
                    catch (Exception exception)
                    {
                        list.Add(new CheckResult(fileName, -1, exception.Message));
                    }
                }
            }
            catch
            {
                throw;
            }

            if (recursive)
            {
                try
                {
                    foreach (string subDirectory in Directory.EnumerateDirectories(directory))
                    {
                        try
                        {
                            list.AddRange(Analyze(subDirectory, filePattern, true, limit, countInAscii));
                        }
                        catch (Exception exception)
                        {
                            list.Add(new CheckResult(subDirectory, -1, exception.Message));
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }

            return list.ToArray();
        }

        #endregion

        #region Private Methods

        private static CheckResult[] Analyze(string fileName, int limit, bool countInAscii)
        {
            string[] lines;

            try
            {
                lines = ReadLines(fileName);
            }
            catch
            {
                throw;
            }

            return CheckLines(fileName, lines, limit, countInAscii);
        }

        private static CheckResult[] CheckLines(string fileName, string[] lines, int limit, bool countInAscii)
        {
            var list = new List<CheckResult>();

            for (int i = 0; i < lines.Length; ++i)
            {
                string line = lines[i];

                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                int length;

                if (countInAscii)
                {
                    try
                    {
                        length = defaultEncoding.GetByteCount(line);
                    }
                    catch
                    {
                        throw;
                    }
                }
                else
                {
                    length = line.Length;
                }

                if (length > limit)
                {
                    list.Add(new CheckResult(fileName, (i + 1), line));
                }
            }

            return list.ToArray();
        }

        private static bool IsUTF8(FileStream stream)
        {
            if (stream.Length > 2)
            {
                var bom = new byte[3];
                stream.Read(bom, 0, 3);

                for (int i = 0; i < 2; ++i)
                {
                    if (bom[i] != utf8Bom[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        private static string[] ReadLines(string fileName)
        {
            string contents;

            try
            {
                using (var stream = new FileStream(fileName, FileMode.Open))
                using (var reader = new StreamReader(stream, (IsUTF8(stream) ? Encoding.UTF8 : Encoding.Default)))
                {
                    try
                    {
                        contents = reader.ReadToEnd();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            catch
            {
                throw;
            }

            return contents.Split(lineSplitter, StringSplitOptions.None);
        }

        #endregion
    }
}
