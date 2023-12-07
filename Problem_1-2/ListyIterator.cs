using System.Collections;

class ListyIterator<T> : IEnumerable<T>
{
    private List<T> list;
    int currentIndex;

    public ListyIterator(T[] array)
    {
        this.list = new List<T>(array);
        this.currentIndex = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in list)
        {
            yield return item;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool hasNext()
    {
        return currentIndex < list.Count-1;
    }

    public bool move()
    {
        if (hasNext())
        {
            currentIndex++;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void print()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Invalide operation!");
        } else
        {
            Console.WriteLine(list[currentIndex]);
        }
    }

    public void printAll()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Invalide operation!");
        }
        else
        {
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
    }
}