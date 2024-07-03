
using Tasks.Models;

List<Leaner> leaner = new List<Leaner>()
{
    new Leaner()
    {
        FirstName = "Kamron",
        LastName = "??????????????",
        Class = 5,
        Grade = Grade.Alo.ToString(),
    },
    new Leaner()
    {
        FirstName = "Afruz",
        LastName = "!!!!!!!!!!",
        Class = 7,
        Grade= Grade.Yaxshi.ToString(),
    },
    new Leaner()
    {
        FirstName = "Saidjon",
        LastName = "Jalolov",
        Class = 8,
        Grade = Grade.Qoniqarli.ToString(),
    },
    new Leaner()
    {
        FirstName = "Karimmjon",
        LastName = "@@@@@@@@@",
        Class = 9,
        Grade = Grade.Yomon.ToString(),
    }
};

Console.Write("Enter the grade: ");
string grade = Console.ReadLine();

for (int itarator = 0; itarator < leaner.ToString().Length; itarator++)
    if (grade == leaner[itarator].Grade)
    {
        Console.WriteLine($"firstName: {leaner[itarator].FirstName}\n" +
                          $"lastName: {leaner[itarator].LastName}\n" +
                          $"Class: {leaner[itarator].Class}\n");
    }

