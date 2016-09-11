using Pruebas_Csharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pruebas_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Escribe la opcion:
            Enum
            Flow
            Vars
            ");
            String opt=Console.ReadLine().ToString();
            switch (opt)
            {
                case "Flow":
                    List<Persona> personas = new List<Persona>() { new Persona("David", 26), new Persona("Alicia", 52) };
                    int i = 0;
                    foreach (Persona persona in personas)
                    {
                        Console.WriteLine("Nombre: " + persona.MyName);
                        //Añadimos algo al final de la cadena
                        persona.MyName += i.ToString();
                        i++;
                    }
                    //Paralelizamos
                    personas.ForEach(p => Console.WriteLine(p.MyName));
                    
                    break;



               case "Enum":
                    myEnumInt enumInt = myEnumInt.uno;
                    myEnumLong enumLong = myEnumLong.lUno;
                    EnumExamples.imprimeEnum(enumInt);
                    EnumExamples.imprimeLong(enumLong);
                    break;
                default:
                    break;       
            }
            //Inicialicización de personas
            
           
            //Dejamos el programa en pausa

            Persona x = new Persona("Ramon", 15);
            int n;
            x.getAge(out  n);
            
            (string, string,string) names = x.LookupName();
            Console.WriteLine($"found {names.Item1} {names.Item2} {names.Item3} .");
            Console.WriteLine(@"{0} es {1}");
            Console.ReadLine();
        }

    }

}
