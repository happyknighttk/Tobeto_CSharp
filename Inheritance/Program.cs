//C# Dersleri 46-47

Person[] persons = new Person[3]
{
    new Customer
    {
        FirstName="Tolga"
    },
    new Student
    {
        FirstName="Ahmet"
    }, new Person
    {
        FirstName="Atacan"
    }
};

foreach (Person person in persons)
{
    Console.WriteLine(person.FirstName);
}


class Person //Base Class
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person //Child Class - Birden fazla Base Class atanamaz
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}