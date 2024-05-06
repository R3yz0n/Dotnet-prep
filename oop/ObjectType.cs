//Boxing When variables/objects moves from Stack to Heap
//UnBoxing When variables/objects moves from Heap to Stack


class ObjectType
{
    public ObjectType()
    {

        Object obj1 = 10;// Boxing
        Object obj2 = obj1;

        System.Console.WriteLine(Object.ReferenceEquals(obj1, obj2)); //True


        int intz = Convert.ToInt32(obj1); //This is unboxing

        obj1 = 20;
        System.Console.WriteLine(Object.ReferenceEquals(obj1, obj2)); //False
        System.Console.WriteLine(obj1);
        System.Console.WriteLine(obj2);


    }
}