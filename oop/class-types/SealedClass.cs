sealed class SealedClass //: OtherClass Possible
{
    public SealedClass()
    {

        System.Console.WriteLine("Sealed Class");
    }
}

class DeriveClass //: SealedClass //No possible
{

}