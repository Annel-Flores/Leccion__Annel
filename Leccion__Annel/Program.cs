using System;
using System.Collections.Generic;

namespace Leccion__Annel
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Orden de reparacion");
            Cliente CLIENTE = new Cliente("Annel Flores");
            CLIENTE.mostrar();
            Dispositivos dispositivo3 = new Dispositivos(CLIENTE, "3", "Xiaomi ", "Redmi Note 9T", "android", "telefono", "tiene chip", "China");
            HW1 hardware1 = new HW1("audifonos");
            HW2 hardware2 = new HW2("cargador");
            HW3 hardware3 = new HW3("estuche");
            Console.WriteLine("reparar :");
            Dispositivos dispositivo1 = new Dispositivos(CLIENTE, "2", "Iphone", "13 pro", "IOS", "tableta", "sin chip", "china Zhengzhou");
            dispositivo1.mostrar();
            Console.WriteLine("fallos en:");
            funcionalidad1 funcion1 = new funcionalidad1();
            funcion1.mostrar();
            Console.WriteLine("harware adicional:");
            hardware1.mostrar();
            Console.WriteLine("reparar :");
            Dispositivos dispositivo2 = new Dispositivos(CLIENTE, "2", "Tecno", "Camon 18P", "android", "telefono", "tiene chip", "china");
            dispositivo2.mostrar();
            Console.WriteLine("fallos en:");
            funcionalidad2 funcion2 = new funcionalidad2();
            funcion2.mostrar();
            Console.WriteLine("harware adicional:");
            hardware2.mostrar();
            funcionalidad3 funcion3 = new funcionalidad3();
            funcion3.mostrar();
            Console.WriteLine("harware adicional:");
            hardware3.mostrar();
        }
    }
}