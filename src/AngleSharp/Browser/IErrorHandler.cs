namespace AngleSharp.Browser
{
    using System;

    /// <summary>
    /// Represents an handler for errors.
    /// </summary>
    public interface IErrorHandler
    {
        void Report(Exception ex);

        T Cure<T>(Exception ex);
    }
}
