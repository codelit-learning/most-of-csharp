namespace MostOfCSharp.Chapters.Oops.Classes
{
    class Person
    {
        public string Name {get; set;}
        public int Age {get;} // read-only property

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old";
        }
    }
}