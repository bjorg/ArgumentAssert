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

public class ArgumentAssertException : ArgumentException {

    //--- Class Methods ---
    public static void Assert(
        [DoesNotReturnIf(false)] bool expression,
        [CallerArgumentExpression("expression")] string? expressionText = default
    ) {
        if(!expression) {
            Throw(expressionText);
        }
    }

    [DoesNotReturn]
    internal static void Throw(string? message) => throw new ArgumentAssertException(message);

    //--- Constructors ---
    public ArgumentAssertException() { }
    public ArgumentAssertException(string? message) : base(message) { }
}

