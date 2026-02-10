// See https://aka.ms/new-console-template for more information


using OOP.Abstraction;
using OOP.Inheritance;
using OOP.Interface;
using OOP.Polymorphism;
using OOP.Services;

// Поліморфізм ///////////////////////////////////////////////////////
List<DiagnosticTool> diagnostics = new List<DiagnosticTool>
{
    new EngineDiagnostic(),
    new BrakeDiagnostic(),
    new AirbagDiagnostic()
};

foreach (DiagnosticTool i in diagnostics)
{
    i.RunDiagnostic();
}

// Абстракція ////////////////////////////////////////////////////////
List<Engine> engines = new List<Engine>();
engines.Add(new PetrolEngine(150));
engines.Add(new DieselEngine(115));
engines.Add(new ElectricEngine(300));

foreach (var i in engines)
{
    i.Start();
}

// Інтерфеси //////////////////////////////////////////////////////////
List<IStartable> startables = new List<IStartable>()
{
    new CarSystem()
};

foreach (var s in startables)
{
    s.Start();
}

List<IStopable> stopables = new List<IStopable>()
{
    new ClimatSystem()
};

foreach (var b in stopables)
{
    b.Stop();
}

List<ILockable> lockables = new List<ILockable>()
{
    new SecuritySystem()
};

foreach (var c in lockables)
{
    c.Lock();
    c.Unlock();
}
var dasboard = new Dashboard();
dasboard.Accelerate(5000);

//Сервіси //////////////////////////////////////////////////////////////
CarInventoryService service = new CarInventoryService();

service.AddCar(new Car("Nissan ", "Rogue ", 16000));
service.AddCar(new Car("Volkswagen ", "Golf V ", 5300));

Console.WriteLine("Автомобілі:");
service.ShowAll();








