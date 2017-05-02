namespace SchoolSystem.Core.Contracts
{
    /// <summary>Provides output-writing functionality.</summary>
    public interface IWriter
    {
        /// <summary>Writes a string of output on the same line.</summary>
        /// <param name="stringValue">Output in string form.</param>
        void Write(string stringValue);

        /// <summary>Writes a whole line of output.</summary>
        /// <param name="stringValue">Output line in string form.</param>
        void WriteLine(string stringValue);
    }
}
