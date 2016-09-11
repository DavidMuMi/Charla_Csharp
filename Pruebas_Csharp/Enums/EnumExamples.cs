using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Csharp.Enums
{
    public enum myEnumInt { uno, dos, tres };
    //byte, sbyte, short, ushort, int, uint, long, ulong
    public enum myEnumLong : uint
    {
        lUno = 1,
        lDos = 2,
        lTres = 3
    }
    public static class EnumExamples
    {
        
        
        public static void imprimeEnum(myEnumInt enumInt)
        {
            switch (enumInt)
            {
                case myEnumInt.uno:
                    Console.WriteLine("uno");
                    break;
                case myEnumInt.dos:
                    Console.WriteLine("dos");
                    break;
                case myEnumInt.tres:
                    Console.WriteLine("tres");
                    break;
                default:
                    break;
            }
            
        }
        public static void imprimeLong(myEnumLong enumLong)
        {
            switch (enumLong)
            {
                case myEnumLong.lUno:
                    Console.WriteLine("uno");
                    break;
                case myEnumLong.lDos:
                    Console.WriteLine("dos");
                    break;
                case myEnumLong.lTres:
                    Console.WriteLine("tres");
                    break;
                default:
                    break;
            }
        }


    }

   
        
}


