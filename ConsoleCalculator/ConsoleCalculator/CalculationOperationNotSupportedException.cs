namespace ConsoleCalculator;

public class CalculationOperationNotSupportedException : CalculationException
{
    private const string DefaultMessage =
            "Specified operation was out of the range of valid values.";

    public string? Operation { get; }

    /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a 
    /// predefined message.  
    public CalculationOperationNotSupportedException()
        : base(DefaultMessage)
    {
    }

    /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a predefined
    /// message and a wrapped inner exception.
    public CalculationOperationNotSupportedException(Exception innerException)
        : base(DefaultMessage, innerException)
    {
    }

    /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a 
    /// user-supplied message and a wrapped inner exception.
    public CalculationOperationNotSupportedException(string message,
                                                     Exception innerException) 
        : base(message, innerException)
    {
    }

    /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the 
    /// a default message and the operation that is not supported.
    public CalculationOperationNotSupportedException(string operation)
        : this() => Operation = operation;

    /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the 
    /// operation that is not supported and a user-supplied message.
    public CalculationOperationNotSupportedException(string operation, string message)
        : base(message) => Operation = operation;

    public override string Message
    {
        get
        {
            if (Operation is null)
            {
                return base.Message;
            }

            return base.Message + Environment.NewLine +
                $"Unsupported operation: {Operation}";
        }
    }
}
