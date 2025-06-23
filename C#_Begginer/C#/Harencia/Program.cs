Doctor doctor1 = new Doctor("Jose", 45, "cardiologo");
Console.WriteLine(doctor1.GetInfo()); //Metodo del padre
Console.WriteLine(doctor1.GetData()); //Metodo del doctor

Dev dev1 = new Dev("Antonio", 23, "CSharp");
Console.WriteLine(dev1.GetInfo());
Console.WriteLine(dev1.GetData());

class People
{
    private string _name;
    private int _age;

    public People(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetInfo()
    {
        return _name + " " + _age;
    }
}

class Doctor : People
{
    private string _speciality;
    public Doctor(string name, int age, string speciality) : base(name, age)
    {
        _speciality = speciality;
    }

    public string GetData()
    {
        return GetInfo() +  " " + _speciality;
    }
}

class Dev : People
{
    private string _language;
    public Dev(string name, int age, string language) : base(name, age)
    {
        _language = language;
    }

    public string GetData()
    {
        return GetInfo() +  " " + _language;
    }
}