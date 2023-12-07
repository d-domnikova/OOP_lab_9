class Workspace
{
    static void Main(String[] args)
    {
        SortedSet<Person> sortedSetPerson = new SortedSet<Person>();
        HashSet<Person> hashSetPerson = new HashSet<Person>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string name = input[0];
            int age = int.Parse(input[1]);
           
            Person person = new Person(name, age);
            sortedSetPerson.Add(person);
            hashSetPerson.Add(person);
        }

        Console.WriteLine($"{sortedSetPerson.Count} {hashSetPerson.Count}");
    }
}