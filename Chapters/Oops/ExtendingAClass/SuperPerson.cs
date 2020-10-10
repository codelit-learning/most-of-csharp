using MostOfCSharp.Chapters.Oops.Classes;

namespace MostOfCSharp.Chapters.Oops.ExtendingAClass
{
    class SuperPerson : Person
    {
        public string Power { get; set; }

        public SuperPerson(string name, int age, string power): base(name, age)
        {
            Power = power;
        }

        public override string ToString()
        {
            return $"{base.ToString()} and (s)he can {Power}";
        }
    }
}