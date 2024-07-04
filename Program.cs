
using Tasks.Models;

//List<Leaner> leaner = new List<Leaner>()
//{
//    new Leaner()
//    {
//        Id = new Guid(),
//        FirstName = "Kamron",
//        LastName = "??????????????",
//        Class = 5,
//        Grade = Grade.Alo.ToString(),
//    },
//    new Leaner()
//    {
//        Id = new Guid(),
//        FirstName = "Afruz",
//        LastName = "!!!!!!!!!!",
//        Class = 7,
//        Grade= Grade.Alo.ToString(),
//    },
//    new Leaner()
//    {
//        Id = new Guid(),
//        FirstName = "Saidjon",
//        LastName = "Jalolov",
//        Class = 8,
//        Grade = Grade.Qoniqarli.ToString(),
//    },
//    new Leaner()
//    {
//        Id = new Guid(),
//        FirstName = "Karimmjon",
//        LastName = "@@@@@@@@@",
//        Class = 9,
//        Grade = Grade.Yomon.ToString(),
//    }
//};

//Console.Write("Enter the grade: ");
//string grade = Console.ReadLine();

//for (int itarator = 0; itarator < leaner.ToString().Length; itarator++)
//    if (grade == leaner[itarator].Grade)
//    {
//        Console.WriteLine($"Id: {leaner[itarator].Id}\n" +
//                          $"firstName: {leaner[itarator].FirstName}\n" +
//                          $"lastName: {leaner[itarator].LastName}\n" +
//                          $"Class: {leaner[itarator].Class}\n");
//    }


List<Car> cars = new List<Car>()
{
    new Car()
    {
        Name = "Lacetti",
        Marka = "Chevrolet",
        Cost = 12000
    },
    new Car()
    {
        Name = "Jiguli",
        Marka = "Lada",
        Cost = 8000
    },
    new Car()
    {
        Name = "X5",
        Marka = "BMW",
        Cost = 15000
    },
    new Car()
    {
        Name = "Mers 222",
        Marka = "Mercedes",
        Cost = 20000
    }
};

Console.Write("Enter the first price: ");
decimal price = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter the second price: ");
decimal second = Convert.ToDecimal(Console.ReadLine());

foreach (var car in cars)
{
    if(car.Cost >= price && car.Cost <= second)
    {
        Console.WriteLine($"{car.Name}, {car.Marka}, {car.Cost}");
    }
}
