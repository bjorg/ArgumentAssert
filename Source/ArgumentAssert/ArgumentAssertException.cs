/*
 *   Copyright 2022 - Steve Bjorg
 *
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 */

namespace System;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

/// <summary>
/// The <see cref="ArgumentAssertException"/> class represents an exception that is
/// thrown when an assertion fails.
/// </summary>
public class ArgumentAssertException : ArgumentException {

    //--- Class Methods ---

    /// <summary>
    /// This method throws a <see cref="ArgumentAssertException"/> exception when the expression evaluates to false.
    /// The method is annotated to inform code analysis about that the assertions of the expression are true when no
    /// exception is thrown.
    /// </summary>
    /// <param name="expression">Expression to assert on</param>
    /// <param name="expressionText">(optional) Text for exception message. The string equivalent of the expression used when omitted.</param>
    public static void Assert(
        [DoesNotReturnIf(false)] bool expression,
        [CallerArgumentExpression("expression")] string? expressionText = default
    ) {
        if(!expression) {
            Throw(expressionText);
        }
    }

    [DoesNotReturn]
    private static void Throw(string? message) => throw new ArgumentAssertException(message);

    //--- Constructors ---
    public ArgumentAssertException() { }
    public ArgumentAssertException(string? message) : base(message) { }
}
