
Person Dima = new Employee("Dima", 15, "Spec", 1234567, 11223344);

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
    public void Rename (string newName)
    {
        name = newName;
    }
}

class Employee : Person
{
    public string job = "Undefined";
    public int accountNumber;
    public int assuranceNumber;


    public Employee(string n, int a, string j, int ac, int an)
    {
        name = n;
        age = a;
        job = j;
        accountNumber = ac;
        assuranceNumber = an;
    }
    public override void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age} Профессия: {job} Номер счета: {accountNumber} Номер страховки: {assuranceNumber}");
    }
}
