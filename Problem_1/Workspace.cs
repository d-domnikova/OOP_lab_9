class Workspace
{
    static void Main(String[] args)
    {
        Console.Write("Create ");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        ListyIterator<string> listyIterator = new ListyIterator<string>(input);

        while (true)
        {
            try
            {
                string line = Console.ReadLine();
                if (line.ToLower().Contains("end")) break;

                switch (line.ToLower())
                {
                    case "hasnext":
                        Console.WriteLine(listyIterator.hasNext());
                        break;
                    case "move":
                        Console.WriteLine(listyIterator.move());
                        break;
                    case "print":
                        listyIterator.print();
                        break;
                    case "printall":
                        listyIterator.printAll();
                        break;
                    default:
                        throw new InvalidOperationException("Invalide operation!");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}