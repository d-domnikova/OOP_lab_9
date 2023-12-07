class Person
{
    public string name { get; set; }
    public int age { get; set; }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{name} {age}";
    }
}
