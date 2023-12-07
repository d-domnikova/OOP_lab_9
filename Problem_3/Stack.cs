using System.Collections;

class Stack<T> : IEnumerable<T>
{
    private List<T> stack;

    public Stack()
    {
        stack = new List<T>();
    }

    public Stack(T[] array)
    {
        this.stack = new List<T>(array);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = stack.Count-1; i > -1; i--)
        {
            yield return stack[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void push(T[] array)
    {
        foreach (T item in array)
        {
            stack.Add(item);
        }
    }

    public void pop()
    {
        if (stack.Count == 0)
        {
           Console.WriteLine("No elements.");
        }
        else
        {
           stack.RemoveAt(stack.Count-1);
        }
    }
}