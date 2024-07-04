
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


//List<Car> cars = new List<Car>()
//{
//    new Car()
//    {
//        Name = "Lacetti",
//        Marka = "Chevrolet",
//        Cost = 12000
//    },
//    new Car()
//    {
//        Name = "Jiguli",
//        Marka = "Lada",
//        Cost = 8000
//    },
//    new Car()
//    {
//        Name = "X5",
//        Marka = "BMW",
//        Cost = 15000
//    },
//    new Car()
//    {
//        Name = "Mers 222",
//        Marka = "Mercedes",
//        Cost = 20000
//    }
//};

//Console.Write("Enter the first price: ");
//decimal price = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Enter the second price: ");
//decimal second = Convert.ToDecimal(Console.ReadLine());

//foreach (var car in cars)
//{
//    if(car.Cost >= price && car.Cost <= second)
//    {
//        Console.WriteLine($"{car.Name}, {car.Marka}, {car.Cost}");
//    }
//}

List<Boxer> boxers = new List<Boxer>()
{
    new Boxer()
    {
        Id = new Guid(),
        FirstName = "Baxodir",
        LastName = "Jalolov",
        Age = 27,
        Weight = 90
    },
    new Boxer()
    {
        Id = new Guid(),
        FirstName = "Shahram",
        LastName = "Giyosov",
        Age = 28,
        Weight = 80
    },
    new Boxer()
    {
        Id = new Guid(),
        FirstName = "Hasanboy",
        LastName = "Dusmatov",
        Age = 29,
        Weight = 50
    },
    new Boxer()
    {
        Id = Guid.NewGuid(),
        FirstName = "Shoxjahon",
        LastName = "Ergashev",
        Age = 30,
        Weight = 60
    },
    new Boxer()
    {
        Id = new Guid(),
        FirstName = "Murodjon",
        LastName = "Ahmadaliyev",
        Age = 31,
        Weight = 60
    }
};

List<Boxer> yengilBokschilar = new List<Boxer>();
List<Boxer> ortaBokschilar = new List<Boxer>();
List<Boxer> ogirBokschilar = new List<Boxer>();

// Bokschilarni vazn toifalariga ajratish
foreach (Boxer boxer in boxers)
{
    if (boxer.Weight <= 50)
    {
        yengilBokschilar.Add(boxer);
    }
    else if (boxer.Weight > 50 && boxer.Weight <= 76)
    {
        ortaBokschilar.Add(boxer);
    }
    else
    {
        ogirBokschilar.Add(boxer);
    }
}
Console.WriteLine("\nYengil vaznli bokschilar:");
foreach (Boxer boxer in yengilBokschilar)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Boxer Id:  {boxer.Id}\n" +
                      $"Boxer First Name: {boxer.FirstName}\n" +
                      $"Boxer Last Name: {boxer.LastName}\n" +
                      $"Boxer Age: {boxer.Age} \n" +
                      $"Boxer Weight: {boxer.Weight} \n");
    Console.ResetColor();
}

Console.WriteLine("\nO'rta vaznli bokschilar:");
foreach (Boxer boxer in ortaBokschilar)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Boxer Id:  {boxer.Id}\n" +
                      $"Boxer First Name: {boxer.FirstName} \n" +
                      $"Boxer Last Name: {boxer.LastName}\n" +
                      $"Boxer Age: {boxer.Age}\n" +
                      $"Boxer Weight: {boxer.Weight}\n");
    Console.ResetColor();
}
    
Console.WriteLine("\nOg'ir vaznli bokschilar:");
foreach (Boxer boxer in ogirBokschilar)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine($"Boxer Id:  {boxer.Id}\n" +
                      $"Boxer First Name: {boxer.FirstName}\n" +
                      $"Boxer Last Name: {boxer.LastName}\n" +
                      $"Boxer Age: {boxer.Age}\n" +
                      $"Boxer Weight: {boxer.Weight}\n");
    Console.ResetColor();
}
