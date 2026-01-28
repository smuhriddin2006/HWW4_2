using Task3.Interface;

namespace Task3;

public class Thermostat : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The Thermostat is on");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The thermostat is off");
    }

}
