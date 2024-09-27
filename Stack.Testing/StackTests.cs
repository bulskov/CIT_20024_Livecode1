namespace Stack.Testing;

public class StackTests
{
    [Fact]
    public void StackShouldBeEmptyWhenCreated()
    {
        var stack = new Stack();

        Assert.Equal(stack.Count, 0); 
    }

}

class Stack
{

    public int Count { get; set; }
}
