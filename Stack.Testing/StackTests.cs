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

    [Fact]
    public void StackShouldStoreMultipleValuesWhenPushed()
    {
        var stack = new Stack();

        stack.Push(1);
        stack.Push(2);
        stack.Pop();
        var result = stack.Pop();

        result.Should().Be(1);
    }

}

class Stack
{
    int[] _value = new int[2];

    public int Count { get; private set; } = 0;

    public void Push(int value)
    {
        _value[Count] = value;
        Count++;
    }

    public int Pop()
    {
        var pos = Count - 1;
        Count--;
        return _value[pos];
    }
}
