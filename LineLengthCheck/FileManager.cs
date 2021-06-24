using System.IO;
using System.Text;

namespace LineLengthCheck
{
    public static class FileManager
    {
        #region Public Methods

        public static void OutputReport(CheckResult[] checkResults, string fileName)
        {
            var builder = new StringBuilder();

            foreach (CheckResult checkResult in checkResults)
            {
                builder.AppendFormat("{0}({1}) {2}", checkResult.FileName, checkResult.Line, checkResult.Contents);
                builder.AppendLine();
            }

            try
            {
                File.WriteAllText(fileName, builder.ToString());
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}
