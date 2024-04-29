class Array
{
    public Array()
    {

        //Array methos (static)
        //Clear Sort Reverse

        //Non static
        //GetLength ToList ToString GetValue

        //1D array
        int[] a1 = { 0 };
        int[] a2 = { 0 };
        // System.Console.WriteLine(Array.Equals(a1, a2));
        int[] numbers;
        numbers = new int[5];
        System.Console.WriteLine(numbers.GetValue(0));

        //Rectangular Array

        int[,] rectangle = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        // for (int i = 0; i < rectangle.GetLength(0); i++)
        // {
        //     for (int j = 0; j < rectangle.GetLength(1); j++)
        //     {
        //         Console.Write(rectangle[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }

        //Jagged Array
        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        // System.Console.WriteLine(jagged.GetLength(0));

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }



    }
}