using System.Collections;

namespace ConsoleApp4.PracticeGenerics;

public class MyList<T>
{
    private List<T> _list;

    public MyList()
    {
        _list = new List<T>();
    }

    public void Add(T item)
    {
        _list.Add(item);
    }

    public T Remove()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException();
        }
        T last = _list[^1];
        _list.RemoveAt(_list.Count-1);
        return last;
    }

    public bool Contains(T item)
    {
        if (_list.Contains(item))
        {
            return true;
        }
        return false;
    }

    public void Clear()
    {
        _list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        _list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        _list.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index >= _list.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return _list[index];
    }

    public void Print()
    {
        foreach (var item in _list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}