using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_ConsoleProyectDPA
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = "Desarrollo de Ambiente web 2021-1";
            int edad = 2;
            double monto = 350.3;
            string salario = "mil dolares";


            var nuevaEdad = "Veinte";

            string detalleEdad = String.Empty;


            List<Persona> listado = new List<Persona>();

            Persona per1 = new Persona();

            per1.dni = "12345678";
            per1.nombreCompleto = "Jefferson farfan";
            per1.telefono = 45687979;

            Persona per2 = new Persona("456768486", "Paolo Guerrero", 95865895);

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(new Persona("15648654", "Raul Ruidiaz", 4589854));

            detalleEdad = edad > 17 ? "Es mayor de edad" : "Es menor de edad";
            //if (edad>17)
            //{
            //    detalleEdad = "Es mayor de edad";
            //}
            //else
            //{
            //    detalleEdad = "Es menor de edad";
            //}

            //ITERANDO OBJETOS

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.telefono);
            }

            var busqueda = listado.Where(x=>x.dni == "12345678").FirstOrDefault();

            Console.WriteLine(busqueda.nombreCompleto);
        }
    }
}
