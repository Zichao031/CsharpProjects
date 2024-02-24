namespace ConsoleApp4.PracticeGenerics;

public class MyStack<T>
{
    private int _count;
    private List<T> _items;

    public MyStack()
    {
        _count = 0;
        _items = new List<T>();
    }
    public int Count()
    {
        return _count;
    }

    public T Pop()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Cannot pop an empty stack");
        } 
         
        T popped = _items[^1];
        _items.RemoveAt(_items.Count-1);
        _count--;
        return popped;
    }

    public void Push(T t)
    {
        _count++;
        _items.Add(t);
    }
}