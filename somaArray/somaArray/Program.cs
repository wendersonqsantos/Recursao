using System;

namespace somaArray
{
    class Program
    {
        public static double[] geraVetor(double[] vet)
        {
            int tamanho = 0;
            Console.WriteLine("Informe o tamanho do vetor:");
            tamanho = int.Parse(Console.ReadLine());
            vet = new double[tamanho];
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Informe um valor real:");
                vet[i] = double.Parse(Console.ReadLine());
            }
            return vet;
        }
        public static double calcular(double[] vet,int soma)
        {

            if (soma == 0)
            {
                return 0;
            }
            else return vet[soma - 1]+calcular(vet,soma-1);
        }
        public static void imprimir(double[] vet) 
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(" "+vet[i] );
            }
        }
        static void Main(string[] args)
        {
            double[] vet;
            double calculo=0;
            int tamanho=0;
            vet = new double[tamanho];
            vet=geraVetor(vet);
           calculo= calcular(vet, vet.Length);
            Console.WriteLine("Resultado:"+calculo);
            Console.ReadKey(); 
        }
    }
}
