using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            /// loop com while
            
            while (a <= 5)
            {
                Console.WriteLine(a);
                a++; /// não esque de colocar para não entrar no loop infinito.
                
            }
            while (a <= 10)
            {
                if (a == 6)
                {
                    a++; /// tem que colocar para não entrar no loop infinito
                    continue; /// Ele pula um loop
                }
                Console.WriteLine(a);
                a++; /// não esque de colocar para não entrar no loop infinito.
            }


            /// O do while simula primeiro e depois vê a condição; 
            int b = 11;

            do
            {
                if (b == 100)
                {
                    break; /// Serve para para o for. 
                }
                Console.WriteLine(b);
                b++;
            } while (b <= 15);

            /// For é igual ao C++
            
            for(int c = 16; c <= 20; c++)
            {
                Console.WriteLine(c);
            }

            /// Para um vetor é presico começar no 0 na posição.
            /// length devolver o tamanho do vetor. 

            /// foreach é utilizado para trabalhar com vetor
            int[] aux = {21,22,23,24,25};

            foreach(int i in aux)
            {
                Console.WriteLine(i);
            }

            /// função recursiva também é utilizado em loop
            /// A função void não retorna nada, por exemplo, quando colocar um int é preciso utilizar um return.

            looping(26);

            Console.Read();
        }
        public static void looping(int aux3)
        {
            Console.WriteLine(aux3);
            if (aux3 < 30)
            {
                looping(aux3+1);
            }
            }
    }
}
