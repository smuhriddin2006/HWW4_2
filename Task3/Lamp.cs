using Task3.Interface;

namespace Task3;

public class Lamp : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The Lamp is off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The lamp is on");
    }

}
