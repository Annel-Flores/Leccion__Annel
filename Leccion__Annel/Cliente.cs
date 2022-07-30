using System;
using System.Collections.Generic;
using System.Text;

namespace Leccion__Annel
{
    public class Cliente : IChip
    {
        public string Nombre;

        public Cliente(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void mostrar()
        {
            Console.WriteLine("Datos del cliente: " + Nombre);
        }
    }
}