//Create complicated object in better way
interface IPerson
{
    IPerson Clone();
}
class Person:IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IPerson Clone()
    {
        return new Person();
    }
}

public class PrototypeProgramme
{
    //public static void Main(string[] args)
    //{
    //    Person person1 = new Person();

    //    //object creating by copying
    //    Person person2 = person1.Clone() as Person;
    //    Console.WriteLine(person2.FirstName);
    //}
}