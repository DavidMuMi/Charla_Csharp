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
            //Inicialicización de personas
            List<Persona> personas = new List<Persona>() { new Persona("David",26), new Persona ("Alicia",52)};
            int i = 0;
            foreach( Persona persona in personas)
            {
                Console.WriteLine("Nombre: "+persona.MyName);
                //Añadimos algo al final de la cadena
                persona.MyName += i.ToString();
                i++;
            }

            //Paralelizamos
            personas.ForEach(p => Console.WriteLine(p.MyName));
           
            //Dejamos el programa en pausa
            int ine = 2;
            
            Console.WriteLine(@"{0} es {1}");
            Console.ReadLine();
        }
    }
    class Persona
    {
        public int edad { get; set; }
        int cosa;
        public Persona(string nombre, int edad)
        {
            this.name = nombre;
            this.edad = edad;
            this.MyProperty = 7;
        }
        private String name;

        public String MyName
        {
            get { return name; }
            set { name = value; }
        }
        public int MyProperty { get;}
        

    }
}
