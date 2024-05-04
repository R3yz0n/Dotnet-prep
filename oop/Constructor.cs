
// Deconstructor or deconstructing method is the opposite of the constructor. It allows us to return object fields to
//  variables in one statement.
class Constructor
{
    public string FirstName { get; }
    public string LastName { get; }

    public Constructor(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        System.Console.WriteLine("OBject construction....");
    }

    public void Deconstruct(out string firstName, out string lastName)
    {
        System.Console.WriteLine("Deconstructing....");
        firstName = FirstName;
        lastName = LastName;
    }



}