class nameComparer : IComparer<Person> 
{ 
    public int Compare(Person person1, Person person2)
    {
        int lenghtComparer = person1.name.Length.CompareTo(person2.name.Length);
        if (lenghtComparer !=0 ) return lenghtComparer;
        return string.Compare(person1.name.ToLower(), person2.name.ToLower());
    }
}

class ageComparer : IComparer<Person>
{
    public int Compare(Person person1, Person person2)
    {
       return person1.age.CompareTo(person2.age);
    }
}