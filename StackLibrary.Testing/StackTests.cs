using FluentAssertions;

namespace StackLibrary;

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
