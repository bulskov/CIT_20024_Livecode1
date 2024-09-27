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

    [Fact]
    public void StackShouldStoreValueWhenPushed()
    {
        var stack = new Stack();

        stack.Push(1);
        var result = stack.Pop();

        result.Should().Be(1);
    }

    [Fact]
    public void StackShouldStoreAnyValueWhenPushed()
    {
        var stack = new Stack();

        stack.Push(1111);
        var result = stack.Pop();
        result.Should().Be(1111);
    }

}

class Stack
{
    int _value;

    public int Count { get; set; }

    public void Push(int value)
    {
        Count++;
        _value = value;
    }

    public int Pop()
    {
        return _value;
    }
}
