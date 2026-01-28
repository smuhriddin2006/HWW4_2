using Task3.Interface;

namespace Task3;

public class Lockk : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The Lock is off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The lock is on");
    }

}
