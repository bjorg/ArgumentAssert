# ArgumentAssert

`ArgumentAssert` is a library that simplifies asserting conditions on arguments. If the condition is not met, an `ArgumentAssertException` is thrown with a description of the failed check. In addition, the `Assert()` method informs code-analysis that the check must have been true if execution continues.

Run the `dotnet` command from your project folder to add the `ArgumentAssert` package:
```
dotnet add package ArgumentAssert
```

## Sample: Assertion throws exception

The following code asserts the `value` argument is within the expected range or throws an `ArgumentAssertException` exception.
```csharp
int AssertValueIsInRange(int value) {
    ArgumentAssertException.Assert(value is > 0 and < 10);
    return value;
}
```

When the assertion fails, the exception message shows the failed expression.
```
Unhandled exception. System.ArgumentAssertException: value is > 0 and < 10
```

## Sample: Assertion informs code analysis

The following code asserts the `value` argument is not null and has a length between 1 to 9 characters. Code analysis knows that the pattern is true when `Assert()` returns successfully. Therefore, there is no warning for the `return` statement.
```csharp
string AssertValueIsNotNull(string? value) {
    ArgumentAssertException.Assert(value is { Length: > 0 and < 10 });

    // no warning on the following line
    return value.ToUpper();
}
```

When the assertion fails, the exception message shows the failed expression.
```
Unhandled exception. System.ArgumentAssertException: value is { Length: > 0 and < 10 }
```

## License

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
