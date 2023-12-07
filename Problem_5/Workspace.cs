class Workspace
{
    static void Main(String[] args)
    {
        List<Person> people = new List<Person>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower().Contains("end")) break;

            string name = input[0];
            int age = int.Parse(input[1]);
            string town = input[2];
            people.Add(new Person(name, age, town));
        }
        int n = int.Parse(Console.ReadLine());
        int equal = 0, notEqual = 0;
        foreach (Person person in people)
        {
           if(people[n-1].CompareTo(person) == 0)
            {
                equal++;
            } else
            {
                notEqual++;
            }
        }
        if (equal == 1)
        {
            Console.WriteLine("No matches.");
        } else
        {
            Console.WriteLine($"{equal} {notEqual} {people.Count}");
        }
    }
}