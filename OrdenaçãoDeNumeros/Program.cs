using System;

namespace OrdenaçãoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 5, 3, 2, 4, 7, 1, 0, 6 };

            int j, i, n;

            for (i = 0; i < vetor.Length; i++)
            {
                n = vetor[i];

                j = i;

                while ((j > 0) && (vetor[j-1]>n))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = n;
            }
            Console.Write("Vetor = { ");
            foreach (var item in vetor)
            {               
                Console.Write(item + " ");
           
            }
      
            Console.WriteLine("}");
        }
    }
}
