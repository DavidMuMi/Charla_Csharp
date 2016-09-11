using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Csharp
{
    class Persona
    {
        public int edad { get; set; }
        
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
        public int MyProperty { get; }
        public int getAge(out int i)
        {
            i = new int();
            i = this.edad;
            return i;
        }

        public (string, string, string) LookupName() // tuple return type
        {
        return (this.name, this.name, this.name); // tuple literal
        }
    }
}
