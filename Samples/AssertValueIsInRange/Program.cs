AssertValueIsInRange(10);

int AssertValueIsInRange(int value) {
    ArgumentAssertException.Assert(value is > 0 and < 10);
    return value;
}