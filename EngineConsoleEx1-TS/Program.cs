// See https://aka.ms/new-console-template for more information
using EngineConsoleEx1_TS;
using System;
using System.Reflection;


static void DisplayString(string text)
{
    Console.WriteLine(text);
}


static void RailCarTest()
{
    //RailCar railCar = new RailCar("18172", 38800, 130000, 130200, RailCarType.Coal_Cars, true);
    //railCar.RecordScaleWeight(164900);
    //DisplayString(railCar.ToString());

    //railCar = new RailCar("18172", 38800, 130000, 130200, RailCarType.Coal_Cars, true);
    //railCar.RecordScaleWeight(144900);
    //DisplayString(railCar.ToString());

    //railCar = new RailCar("18172", 38800, 130000, 130200, RailCarType.Coal_Cars, true);
    // railCar.RecordScaleWeight(14490);
    //DisplayString(railCar.ToString());

    //railCar = new RailCar("18172", 38800, 130000, 130200, RailCarType.Coal_Cars, true);
    //railCar.RecordScaleWeight(194490);
    //DisplayString(railCar.ToString());

}

static void EngineTest()
{
    //EXPECTED
    //Engine engine = new Engine("CP 8002", "48807", 147700, 4400);
    //DisplayString(engine.ToString());

    //MODEL
    //Engine engine = new Engine("", "48807", 147700, 4400);
    //DisplayString(engine.ToString());

    //SERIALNUMBER
    //Engine engine = new Engine("CP 8002", "", 147700, 4400);
    //DisplayString(engine.ToString());

    //WEIGHT
    //Engine engine = new Engine("CP 8002", "44807", -147770, 4400);
    //DisplayString(engine.ToString());

    //WEIGHT INCREMENTS
    //Engine engine = new Engine("CP 8002", "44807", 147770, 4400);
    //DisplayString(engine.ToString());

    //HP 
    //Engine engine = new Engine("CP 8002", "44807", 147700, -4400);
    //DisplayString(engine.ToString());

    //HP 
    //Engine engine = new Engine("CP 8002", "44807", 147700, 4440);
    //DisplayString(engine.ToString());
}

static void TrainTest()
{
    Engine engine = new Engine("CP 8002", "48807", 147700, 4400);
   
    RailCar railCar = new RailCar("18172", 38800, 130000, 130200, RailCarType.Coal_Cars, true);
    railCar.RecordScaleWeight(164500);

    Train train = new Train(engine);
    train.AddRailCar(railCar);
    DisplayString($"{train.TotalCars},{train.GrossWeight},{train.MaxGrossWeight}");

    // INCOMPLETE TEST. COULDNT GET TEST DATA " OVER GROSS WEIGHT " EXCEPTION TO THROW. BECAUSE ENGINE HP EXCEPTION THROWS FIRST. 

    // engine = new Engine("CP 8002", "48807", 4400, 3600);
    // railCar = new RailCar("18172", 75000, 130000, 400000, RailCarType.Coal_Cars, true);
    // railCar.RecordScaleWeight(450000);

    // train = new Train(engine);
    // train.AddRailCar(railCar);
    // DisplayString($"{train.TotalCars},{train.GrossWeight},{train.MaxGrossWeight}");
}


RailCarTest();
EngineTest();
TrainTest();