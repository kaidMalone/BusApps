namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt16(Console.ReadLine());
        int x = 0;

        for(int i = 1; i <= n; i++){
            if(n%i == 0){
                x++;
            }
        }

        if(x == 2){
            Console.WriteLine("N is prime");
        } else {
            Console.WriteLine("N is non-prime");
        }

        // Question 2
        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                Console.Write("#");
            }
            Console.WriteLine();
        }

        // Bonus 
        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());

        for(int i = 1; i <= n; i++){
            for(int j = i; j > 0; j--){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
