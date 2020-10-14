using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar primer palabra:");
            string Palabra1 = "";
            string Palabra2 = "";
            char[] str;
            char[] caracteres2;
            bool isAnagrama=false;
            Palabra1 = Console.ReadLine();

            Console.WriteLine("Ingresar segunda palabra:");
            Palabra2 = Console.ReadLine();

             //Console.WriteLine(Palabra1 + "..." + Palabra2);

            str = Palabra1.ToCharArray();
            caracteres2 = Palabra2.ToCharArray();

            if(caracteres2.Length == str.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < caracteres2.Length; j++)
                    {
                        
                        if (str[i] == caracteres2[j])
                        {
                            
                            Array.Clear(caracteres2, j, 1);
                            isAnagrama = true;
                            break;


                        }
                        else
                        {
                            isAnagrama = false;
                        }
                    }

                    
                }
            }
            for(int k=0;k < caracteres2.Length; k++)
            {
                if(Convert.ToUInt16(caracteres2[k]) > 0)
                {
                    isAnagrama = false;
                }
            }
            
            if ( isAnagrama)
            {
                Console.WriteLine("Encontraste un Anagrama");
            }


            Console.ReadKey();
        }
    }
}
