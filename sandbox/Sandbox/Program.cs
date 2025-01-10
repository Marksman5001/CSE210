using System;

class Program
{
    static void Main(string[] args)
    {
        int x=0;
        while(x<10){
            string xstring = x.ToString();
            Console.Write(xstring);
            if(x%2 == 0){
                Console.WriteLine(", X is even!");
            }
            else{
                Console.WriteLine();
            }
            x++;
        }

        Console.WriteLine("Hello Sandbox World!");
    }
}