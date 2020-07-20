namespace LoggerApp
{
    public interface ILogFile
    {
        string AllText { get; }

        int Size { get; }

        void Write(string error);
    }
}
