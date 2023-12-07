class Person : IComparable<Person>
{
    public string name { get; set; }
    public int age { get; set; }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override bool Equals(object obj)
    {
        if (obj is Person person)
        {
            if (name == person.name && age == person.age)
                return true;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name, age);
    }

    public int CompareTo(Person person)
    {
        int compareByName = name.CompareTo(person.name);
        if (compareByName != 0) { return compareByName; }

        return age.CompareTo(person.age);
    }
}
