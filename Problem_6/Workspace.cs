class Workspace
{
    static void Main(String[] args)
    {
        SortedSet<Person> sortByName = new SortedSet<Person>(new nameComparer());
        SortedSet<Person> sortByAge = new SortedSet<Person>(new ageComparer());
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string name = input[0];
            int age = int.Parse(input[1]);
           
            sortByName.Add(new Person(name, age));
            sortByAge.Add(new Person(name, age));
        }

        Console.WriteLine();
        foreach (Person person in sortByName)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine();
        foreach (Person person in sortByAge)
        {
            Console.WriteLine(person);
        }
    }
}