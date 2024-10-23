using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        string again = "a";
        while(again == "a") {
            Console.WriteLine("*******************************");
            Console.WriteLine("********** Výpis řady *********");
            Console.WriteLine("*******************************");
            Console.WriteLine("****** Edgar L. Guerrero ******");
            Console.WriteLine("*******************************\n\n");
            Console.WriteLine();

            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

            Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady (celé číslo): ");
            }

            Console.Write("Zadejte diference (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diference (celé číslo): ");
            }

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference: {0}", step);
            Console.WriteLine();
            Console.WriteLine();

            int current = first;
            while(current <= last) {
                Console.WriteLine(current);
                current = current + step;
            }


            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}