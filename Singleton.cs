//Singleton Design Pattern

class SingleObject
{
    //creating the only object this class will have
    private static SingleObject instance = new();

    //making the constructor private
    //so that no object can be created only the instance object can be used
    private SingleObject() { }

    //this method will return the only object
    public static SingleObject getInstance()
    {
        return instance;
    }

    //this function can be used only with the instance object
    public void Print()
    {
        Console.WriteLine("Hello world");
    }
}
class Programme
{
    public static void Main(string[] args)
    {
        //get the object
        SingleObject singleObject = SingleObject.getInstance();

        //call the print function
        singleObject.Print();
    }
}