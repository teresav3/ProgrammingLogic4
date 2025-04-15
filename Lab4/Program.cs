namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
    //Problem 1
        for (int i = 1; i <=10; i++) 
        {
        Console.WriteLine(i);
        }
    
    //Problem 2
        for (int i = 1; i <=20; i++)
        
        if (i % 2 == 0)
        {
        Console.WriteLine(i);
        }
    
    //Problem 3
        int number = 5;

        while (number >= 1)
        {
        Console.WriteLine(number);
        number--;
        }

    //Problem 4
        int number1 = 10;

        while (number1 <= 1000)
        {
        Console.WriteLine(number1);
        number1 += 10;
        }

    //Problem 5
        for (int row = 1; row <= 10; row++)
        {
        for (int col = 1; col <= row; col++) 
            {
            Console.Write("*");
            }
            Console.WriteLine();
        }
    } 

}
