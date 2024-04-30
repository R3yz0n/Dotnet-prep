class Types
{
    public Types()
    {

        // int float struct enums are value type
        //string array class interface delegate are refrence type
        // Const as a data member is static

        //Value types are Primitive datatype while reference types are objects

        int num = 10; // Value type variable
        string str = "Hello"; // Reference type variable
        System.Console.WriteLine(num + str);

        // System.Console.WriteLine(num);

        Test obj = new Test();
        obj.Age = 100;
        Test obj1;
        obj1 = obj;
        System.Console.WriteLine(obj.Age);
        obj.Age = 999;

        // System.Console.WriteLine(object.ReferenceEquals(obj, obj1));

        // System.Console.WriteLine(obj1 == obj1);
        string s1 = "sagar";
        // string s2 = "reyzon";
        changeString(s1);
        //Doesnt change
        //But in case of array it does change bcz we are direclty passing a refrence

        System.Console.WriteLine(s1);


        Test t = new Test();

        t.Name = "Alice";
        ModifyObj(t);
        System.Console.WriteLine(t.Name);
        // Test[] a = new Test[5];
        List<Test> testList = new List<Test>();





    }

    void changeString(string s)
    {
        s = "sssssss";
    }

    void ModifyObj(Test t)
    {
        // Modify the properties of the Person instance
        t.Name = "Bob";
        t.Age = 25;
    }

    public class Test
    {

        public string Name = string.Empty;
        public int Age;

    }




}