class Person : IComparable<Person>
{
    public string name { get; set; }
    public int age { get; set; }
    public string town { get; set; }

    public Person(string name, int age, string town)
    {
        this.name = name;
        this.age = age;
        this.town = town;
    }

    public int CompareTo(Person person)
    {
        int compareByName = name.CompareTo(person.name);
        if (compareByName != 0) { return compareByName; }

        int compareByAge = age.CompareTo(person.age);
        if (compareByAge != 0) { return compareByAge; }

        return town.CompareTo(person.town);
    }

}
