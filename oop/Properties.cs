// In C#, a field is a variable (that can be of any type) that is defined inside a class.
// It can be used to define the characteristics of an object or a class. On the other 
// hand, a property is a member of the class that provides an abstraction to set (write) and get (read) 
// the value of a private field.

class Properties
{

    // Manual Property:
    // Manual properties require explicit definition of both the getter and setter methods.They offer more control over what happens when the property 
    // is accessed or modified.
    private string? name;

    public string? Name
    {
        get { return name; }
        set
        {
            if (value != null)
                name = value;
        }
    }

    // Automatic Property:
    // Automatic properties provide a more concise syntax for defining properties where no additional logic is required in the getter or setter.The compiler
    // generates the backing field for you.
    public int RollNo { get; set; }
    // public int RollNo {  set; }   //No allowed

    // Read-only Property:
    // Read-only properties, like automatic properties, have a getter but no setter. Once initialized, their value cannot be modified.

    public string? Address { get; }
    public Properties(string Address)
    {
        this.Address = Address;
    }
    public Properties()
    {
    }


    // public static string? StaticProperty { get; set; }
    private static string? staticProperty;

    public static string? StaticProperty
    {
        get { return staticProperty; }
        set { staticProperty = value; }
    }


}

// When to use each:

// Manual Properties: Use when you need custom logic in your getter or setter, such as validation or calculations.
// Automatic Properties: Use when you need a simple property without additional logic. They are concise and easy to read.
// Read-only Properties: Use when you want to expose data that should not be modified after object creation. They provide immutability and are useful for ensuring data integrity.
// Static Property : To keep a count of the number of objects that are instantiated, or to store a value that must be shared among all instances