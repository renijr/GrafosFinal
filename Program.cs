using System;
using System.Threading;
namespace GrafosFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            
            do
            {
                Menu.ShowMenu();
                op = Convert.ToInt32(Console.ReadLine());
                Menu.MenuActions(op);
                
            } while (op != 0);


        }
    }
}
