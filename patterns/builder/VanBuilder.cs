public class VanBuilder : VehicleBuilder
{
    private AbstractVan vanInProgress;

    public VanBuilder(AbstractVan van) 
    {
        vanInProgress = van;
    }

    public override void BuildBody()
    {
        System.Console.WriteLine("building van body");
    }

    public override void BuildChassis()
    {
        System.Console.WriteLine("building van chassis");
    }

    public override void BuildReinforcedStorageArea()
    {
        System.Console.WriteLine("building van reinforced storage area");
    }

    public override void BuildWindows()
    {
        System.Console.WriteLine("building van windows");
    }

    public override IVehicle Vehicle
    {
        get { return vanInProgress; }
    }
}