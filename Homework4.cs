namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Call Question 1
        Console.WriteLine($"The largest number is: {large(8,3)}");

        // Call Question 2
        star(7, "right");
        star(7, "left");
    }

    // Question 1 Method
    static int large(int a, int b){
        int l;
        Console.WriteLine($"a = {a}; b = {b}");
        
        if(a>b){
            l = a;    
        } else{
            l = b;
        }
        return l;
    }

    // Question 2 Method
    static void star(int n, string shape){
        Console.WriteLine($"N is : {n}; shape is {shape}");

        if(shape == "left"){
            for(int i = 1; i <= n; i++){
                for(int j = i; j > 0; j--){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        } else {
            for(int i = 1; i <= n; i++){
                for(int j = n; j>i; j--){
                    Console.Write(" ");
                }
                for(int k = 0; k < i; k++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
