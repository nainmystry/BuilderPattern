// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


var sportsCarBuilder = new SportsCarBuilder();
var sportsCar = sportsCarBuilder
                .SetTopSpeed(250)
                .SetMake("BMW")
                .SetModel("GT")
                .SetYear(2024)
                .SetColor("Pearl White")
                .Build();

Console.WriteLine(sportsCar);


var suvBuilder = new SUVBuilder();
var mySUV = suvBuilder
    .SetOffRoadCapability(10)
    .SetMake("Toyota")
    .SetModel("Land Cruiser")
    .SetYear(2023)
    .SetColor("Black")               
    .Build();

Console.WriteLine(mySUV);