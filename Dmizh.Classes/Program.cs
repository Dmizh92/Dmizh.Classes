
Person Dima = new Employee("Dima", 15, "Spec");

Dima.Print();


class Person
{
    public string name;
    public int age;
    public Person()
    {
        name = "Undefined";
        age = 18;
    }
    public Person (string n)
    {
        name = n;
        age = 18;
    }
    public Person(string n, int a)
    {
        name = n;
        age = a;
    }
    public virtual void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

class Employee : Person
{
    public string job = "Undefined";
    public Employee(string n, int a, string j)
    {
        name = n;
        age = a;
        job = j;
    }
    public override void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age} Профессия: {job}");
    }
}
