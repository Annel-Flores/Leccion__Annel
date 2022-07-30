using System;
using System.Collections.Generic;
using System.Text;

namespace Leccion__Annel
{
    class HW3 : IChip
    {
        public string adicional;

        public HW3(string adicional)
        {
            this.adicional = adicional;
        }

        public virtual void mostrar()
        {
            Console.WriteLine("con el adicional de :");
            Console.WriteLine(adicional);

        }
    }
}