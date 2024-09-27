namespace Stack.Testing;

public class Stack
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
