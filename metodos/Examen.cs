using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacion_.metodos
{
    public class Examen
    {
        string[] productos = new string[10];


        public void Ingresar()
        {
            Console.WriteLine("ingrese prodecto");
            for (int i = 0; i < 4; i++)
            {
                string product = Console.ReadLine();
                int precio = int.Parse(Console.ReadLine());
            }
        }

    }
}
