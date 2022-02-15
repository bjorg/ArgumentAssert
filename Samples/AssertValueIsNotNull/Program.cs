Console.WriteLine(AssertValueIsNotNull("Hello World!"));

string AssertValueIsNotNull(string? value) {
    ArgumentAssertException.Assert(value is { Length: > 0 and < 10 });

    // no warning on the following line
    return value.ToUpper();
}
