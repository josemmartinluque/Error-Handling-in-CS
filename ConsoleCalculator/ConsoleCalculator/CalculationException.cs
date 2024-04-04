namespace ConsoleCalculator;

public class CalculationException : Exception
{
    private const string DefaultMessage = "An error occurred during calculation. Ensure that the operator is supported and that the values are within the valid ranges for the requested operation.";

    /// Creates a new <see cref="CalculationException"/> with a predefined message.
    public CalculationException() : base(DefaultMessage) { }

    /// Creates a new <see cref="CalculationException"/> with a user-supplied message.
    public CalculationException(string message) : base(message) { }

    /// Creates a new <see cref="CalculationException"/> with 
    /// a predefined message and a wrapped inner exception.
    public CalculationException(Exception innerException) :
        base(DefaultMessage, innerException)
    { }

    /// Creates a new <see cref="CalculationException"/> with a user-supplied message 
    /// and a wrapped inner exception.
    public CalculationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
