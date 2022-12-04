Console.WriteLine("Name your dog:");
string mydogname = Console.ReadLine();
dog mydog = new dog(mydogname);

dog neighboursdog = new dog("Good Girl");

Console.WriteLine($"My dogs name is {mydog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursdog.Name}.");

mydog.Rename("Bad Boy");

while (mydog.LevelOfHapiness != 5)
{
    mydog.Bark();
}

mydog.WagTail();

class dog
{
    private string _name; //field
    private int _levelOfHapiness;

    //constructor
    public dog (string name) //name - let the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }  
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}
