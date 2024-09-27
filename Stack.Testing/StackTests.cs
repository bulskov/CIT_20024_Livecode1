using FluentAssertions;

namespace Stack.Testing;

public class StackTests
{
    [Fact]
    public void StackShouldBeEmptyWhenCreated()
    {
        var stack = new Stack();

        stack.Count.Should().Be(0);
    }

}

class Stack
{

    public int Count { get; set; }
}
