using System;
namespace switchStatement{
    class Program{
        static void Main(string[] args){
            int theval=50;
            switch(theval){
                case 50:
                Console.WriteLine("theval is 50");
                break;
                case 51:
                Console.WriteLine("theval is 51");
                break;
                case 52:
                case 53:
                case 54:
                Console.WriteLine("theval is between 52 and 54");
                break;
            }
        }
    }
}
