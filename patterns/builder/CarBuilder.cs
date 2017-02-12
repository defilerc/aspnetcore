public class CarBuilder : VehicleBuilder
{
    private AbstractCar carInProgress;

    public CarBuilder(AbstractCar car) 
    {
        carInProgress = car;
    }

    public override void BuildBody()
    {
        System.Console.WriteLine("building car body");
    }

    public override void BuildBoot()
    {
        System.Console.WriteLine("building car boot");
    }

    public override void BuildChassis()
    {
        System.Console.WriteLine("building car chassis");
    }

    public override void BuildPassengerArea()
    {
        System.Console.WriteLine("building car passenger area");
    }

    public override void BuildWindows()
    {
        System.Console.WriteLine("building car windows");
    }

    public override IVehicle Vehicle 
    {
        get 
        {
            return carInProgress;
        }
    }
}