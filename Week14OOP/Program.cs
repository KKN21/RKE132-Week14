Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad boy");
Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

while (myDog.LevelOfHappiness !=5)
{
    myDog.Bark();
    
}
myDog.WagWan();

class Dog
{
    private string _name;
    private int _levelOfHappiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
        _levelOfHappiness++;
    }

    public void WagWan()
    {
        Console.WriteLine("Wiggle-Wiggle");
        _levelOfHappiness++;
    }
}