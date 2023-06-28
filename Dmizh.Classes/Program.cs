
Person tom = new Person();

tom.Print();

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
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}