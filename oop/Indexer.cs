//Indexers allow instances of a class or struct to be indexed just like arrays.
// indexed value can be set or retrieved without explicitly specifying  instance member. 
// Indexers resemble properties except that their accessors take parameters. 

class Indexer
{

    private string[] names = new string[10];
    public string this[int index]
    {
        get
        {
            return names[index];

        }
        set
        {
            names[index] = value;

        }

    }




    //properties

    // private int age;
    // public int Age
    // {
    //     get
    //     {
    //         return age;
    //     }
    //     set
    //     {
    //         age = value;
    //     }
    // }

    public Indexer()
    {
        System.Console.WriteLine("Indexer");
    }
}