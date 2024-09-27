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

    [Fact]
    public void StackShouldIncrementCountWhenPushed()
    {
        var stack = new Stack();

        stack.Push(1);

        stack.Count.Should().Be(1);
    }

}

class Stack
{

    public int Count { get; set; }

    public void Push(int value)
    {
        Count++;
    }
}
