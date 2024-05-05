
// If derived class defines same method as defined in its base class, 
// It is known as method overriding in C#. It is used to achieve runtime polymorphism. 
//base keyword is automatically added to the derived class constructer.
//VIRTUAL KEYWORD IS USED FOR METHOD AND PROPERTIES IN BASE CLASS
//OVERRIDE KEYWORD IS USED FOR METHOD AND PROPERTIES IN DERIVED CLASS

class Animal
{
    public string color = "red";
    public virtual int Legs { get; set; }


    public virtual void Eat()
    {
        Console.WriteLine(" Animal is Eating.");

    }


}

class Dog : Animal
{

    public string color;
    public override int Legs { get; set; } = 10;


    public void Bark()
    {
        Console.WriteLine("Woof!");
    }



    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Dog is eating.");
    }
    public void Display()
    {
        System.Console.WriteLine("Animal has " + base.color + " color.");
        Console.WriteLine("Dog has " + color + " color.");

        System.Console.WriteLine("Animal has " + base.Legs + " legs.");
        System.Console.WriteLine("Dog has " + Legs + " legs.");
    }
}