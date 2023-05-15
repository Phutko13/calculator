using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Airchiet romelime varianti : \n 1.Luw/kentoba 2.kalkulatori");
            string starting = Console.ReadLine();
            switch(starting){
                case "1":{
                        Console.WriteLine("Sheiyvanet ricxvi : ");
                        double number = Convert.ToInt32(Console.ReadLine());
                        if (number % 2 == 0) Console.WriteLine("Luwia");
                        else Console.WriteLine("Kentia");
                        break;
                    }  
                case "2":{
                    Console.WriteLine("Sheiyvanet pirveli ricxvi : ");
                    double number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sheiyvanet meore ricxvi : ");
                    double number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sheiyvanet operacia \n 1.+ 2.- 3.* 4./ ");
                    string ending = Console.ReadLine();
                    double number3 = number1 - number2;
                    switch(ending){
                        case "1":{
                            Console.WriteLine(number1 + " + " + number2 + " = " + number1+number2);
                            break;
                        }
                        case "2":{
                            Console.WriteLine(number1 + " - " + number2 + " = " + number3);
                            break;
                        }
                        case "3":{
                            Console.WriteLine(number1 + " / " + number2 + " = " + number1/number2);
                            break;
                        }
                        case "4":{
                            Console.WriteLine(number1 + " * " + number2 + " = " + number1*number2);
                            break;
                        }
                        default:{
                            Console.WriteLine("Araswori sheyvana");
                            break;
                        }
                    }
                        
                }
                default:{
                    Console.WriteLine("Araswori sheyvana");
                    break;
                }
            }
        }
    }
}