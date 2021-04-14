using System;
 
namespace ejercicio_basicos_DDR_1
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            
            int a = 5;
            int b = 30;
            int c = 4;
 
            int suma = a + b + c;
 
            Console.WriteLine ("La suma es "+suma);
 
            Console.ReadLine ();

            
            var nombre = "guan";
            var ciudad = "Constantinopla";
            Console.WriteLine("Hola, "+nombre+" bienvenido a "+ciudad);

            var edad = 20;
            Console.WriteLine("Hola, te llamas "+nombre+" y tienes "+edad+" años");


            int num1 = 824352356;
            int num2 = 134623467;
 
            if (num1 >= num2) {
                Console.WriteLine ("El primer numero es mayor o igual que el segundo");
            } else {
                Console.WriteLine ("El segundo numero es mayor que el primero");
            }
 
            Console.ReadLine ();
        }
        
        
        
    }
}
// dotnet run
// Console.WriteLine("gatooo");