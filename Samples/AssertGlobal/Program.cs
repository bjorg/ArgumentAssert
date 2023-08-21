using static System.ArgumentAssertException;

AssertValueIsInRange(10);

int AssertValueIsInRange(int value) {
    Assert(value is > 0 and < 10);
    return value;
}