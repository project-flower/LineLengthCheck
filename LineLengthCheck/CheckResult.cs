namespace LineLengthCheck
{
    public class CheckResult
    {
        #region Public Fields

        public readonly string Contents;
        public readonly string FileName;
        public readonly int Line;

        #endregion

        #region Public Methods

        public CheckResult(string fileName, int line, string contents)
        {
            Contents = contents;
            FileName = fileName;
            Line = line;
        }

        #endregion
    }
}
