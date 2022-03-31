

var bmwSportLine = new Bmw(new SportLine());
var bmwMSportPacket = new Bmw(new MSportPacket());
var mercedesSSeries = new Mercedes(new SSeries());
var mercedesESeries = new Mercedes(new ESeries());

bmwSportLine.PrintBrand();
bmwMSportPacket.PrintBrand();
mercedesSSeries.PrintBrand();              // In this example there is a bridge beetwen brand of car and model of car
mercedesESeries.PrintBrand();


var bmwESeries = new Bmw(new ESeries());  //I can also do this with bridge pattern but unfortunately Bmw has no E series :D
bmwESeries.PrintBrand();

public abstract class Car
{
    protected IModel _model;
    protected Car(IModel model)
    {
        _model = model;
    }
    public abstract void PrintBrand();
}


public class Bmw : Car
{
    public Bmw(IModel model) : base(model)
    {
    }

    public override void PrintBrand()
    {
        Console.WriteLine("The Brand is BMW " + _model.Brand());
    }
}

public class Mercedes : Car
{
    public Mercedes(IModel model) : base(model)
    {
    }

    public override void PrintBrand()
    {
        Console.WriteLine("The Brand is Mercedes " + _model.Brand());
    }
}

public interface IModel
{
    string Brand();
}

public class SportLine : IModel
{
    public string Brand()
    {
        return "Sport Line";
    }
}

public class MSportPacket : IModel
{
    public string Brand()
    {
        return "M Sport Packet";
    }
}



public class ESeries : IModel
{
    public string Brand()
    {
        return "E Series";
    }
}

public class SSeries : IModel
{
    public string Brand()
    {
        return "S Series";
    }
}