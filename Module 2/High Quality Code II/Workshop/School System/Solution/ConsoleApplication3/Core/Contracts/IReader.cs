namespace SchoolSystem.Core.Contracts
{
    /// <summary>Provides input-reading functionality.</summary>
    public interface IReader
    {
        /// <summary>Reads a line of input.</summary>
        /// <returns>Input in string form.</returns>
        string ReadLine();
    }
}
