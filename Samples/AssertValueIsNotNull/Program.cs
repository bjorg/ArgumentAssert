Console.WriteLine(AssertValueIsNotNull("hi"));

string AssertValueIsNotNull(string? value) {
    ArgumentAssertException.Assert(value is not null);

    // no warning on the following line
    return value.ToUpper();
}
