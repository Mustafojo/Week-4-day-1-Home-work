
public class Car : Ivehicle
{
    public double Gasoline { get; set; }
    public Car(double gasoline)
    {
        Gasoline = gasoline;
    }
    public void Drive()
    {
        System.Console.WriteLine("Drive");
    }
    public bool Refuel()
    {
        Gasoline ++;
        if (Gasoline > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}