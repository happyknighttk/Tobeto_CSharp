//C# Dersleri 28-29

string[] students = new string[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

string[] students2 = { "Engin", "Derin", "Salih" };

foreach (var student in students)
    Console.Write(student + " ");

Console.WriteLine();

foreach (var student in students2)
    Console.Write(student + " ");
