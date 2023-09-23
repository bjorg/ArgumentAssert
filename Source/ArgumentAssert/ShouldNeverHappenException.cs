using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

/// <summary>
/// The <see cref="ShouldNeverHappenException"/> class represents an exception that is
/// thrown when an internal check fails that should never fail.
/// </summary>
public class ShouldNeverHappenException : ApplicationException {

    //--- Class Methods ---

    /// <summary>
    /// This method throws a <see cref="ShouldNeverHappenException"/> exception when the expression evaluates to true.
    /// The method is annotated to inform code analysis about that the assertions of the expression are false when no
    /// exception is thrown.
    /// </summary>
    /// <param name="expression">Expression to verify is false</param>
    /// <param name="expressionText">(optional) Text for exception message. The string equivalent of the expression used when omitted.</param>
    public static void ShouldNeverHappen(
        [DoesNotReturnIf(true)] bool expression,
        [CallerArgumentExpression("expression")] string? expressionText = default
    ) {
        if(expression) {
            Throw(expressionText);
        }
    }

    [DoesNotReturn]
    private static void Throw(string? message) => throw new ShouldNeverHappenException(message);

    //--- Constructors ---
    public ShouldNeverHappenException() { }
    public ShouldNeverHappenException(string? message) : base(message) { }
}
