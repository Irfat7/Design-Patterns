using System.Runtime.InteropServices;

//interface of the builder of what will b built
interface IComputerBuilder
{
    void SetMonitor();
    void SetMouse();
    void SetKeyboard();
    void SetTower();
    void SetPrinter();
    Computer GetComputer();
}

//class of what will be built
public class Computer
{
    public string Monitor { get; set; }
    public string Mouse { get; set; }
    public string Keyboard { get; set; }
    public string Tower { get; set; }
    public string Printer { get; set; }
}

//builder class implementation
class ComputerABuilder : IComputerBuilder
{
    Computer computer = new Computer();

    public void SetKeyboard()
    {
        computer.Keyboard = "Fantech";
    }

    public void SetMonitor()
    {
        computer.Monitor = "MI";
    }

    public void SetMouse()
    {
        computer.Mouse = "Fantech Mouse";
    }

    public void SetPrinter()
    {
        computer.Printer = "EPSON";
    }

    public void SetTower()
    {
        computer.Tower = "Tower";
    }
    public Computer GetComputer()
    {
        return computer;
    }
}

class Client
{
    private IComputerBuilder computerBuilder;

    public Client(IComputerBuilder builderName)
    {
        this.computerBuilder = builderName;
    }

    public void CreateComputer()
    {
        computerBuilder.SetMonitor();
        computerBuilder.SetMouse();
        computerBuilder.SetTower();
        computerBuilder.SetPrinter();
        computerBuilder.SetKeyboard();
    }
    public Computer GetComputer()
    {
        return computerBuilder.GetComputer();
    }
}

public class BuilderProgramme
{
    //public static void Main(string[] args)
    //{
    //    Client client = new(new ComputerABuilder());
    //    client.CreateComputer();
    //    var myComputer = client.GetComputer();

    //    Console.WriteLine(myComputer.Monitor);
    //    Console.WriteLine(myComputer.Tower);
    //    Console.WriteLine(myComputer.Keyboard);
    //    Console.WriteLine(myComputer.Mouse);
    //    Console.WriteLine(myComputer.Printer);
    //}
}