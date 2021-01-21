using System;
using System.Linq;

namespace TopFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da assinatura do TopFlix: ");

            string precoAssinaturaEntrada = Console.ReadLine();
            double precoAssinaturaDouble = double.Parse(precoAssinaturaEntrada);

            // IF-ELSE
            Console.WriteLine("Usando if-else");

            if (precoAssinaturaDouble > 50)
            {
                Console.WriteLine("Que assinatura cara!");
            } else if (precoAssinaturaDouble > 20)
            {
                Console.WriteLine("Marromenos... Me ajude aí.");
            } 
            else
            {
                Console.WriteLine("Agora sim meu chapa.");
            }

            // SWITCH
            Console.WriteLine("Usando SWITCH");

            switch (precoAssinaturaDouble)
            {
                case double n when (n > 50):
                    Console.WriteLine("Que assinatura cara!");
                    break;
                case double n when (n > 20):
                    Console.WriteLine("Marromenos... Me ajude aí.");
                    break;
                default:
                    Console.WriteLine("Agora sim meu chapa.");
                    break;
            }

            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Lista de numeros com while: ");

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.Write(numeros[contador] + " ");

                contador++;
            }

            Console.WriteLine();

            Console.WriteLine("Listas de numeros com for: ");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\nListas de numeros com foreach: ");

            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }

            // LINQ
            var numerosLista = numeros.ToList();
            numerosLista.Add(11);
            numerosLista.Add(99);
            numerosLista.Add(99);

            var existeNumeroMaiorQue100 = numerosLista.Any(n => n > 100);
            var numerosMaioresQue5 = numerosLista.Where(n => n > 5).ToList();
            var numeroIgualA5 = numerosLista.SingleOrDefault(n => n == 5);
            var primeiroNumeroIgualA99 = numerosLista.First(n => n == 99);
            var numerosDobrados = numerosLista.Select(n => n * 2).ToList();
            var maiorNumero = numerosLista.Max();
            var tamanhoLista = numerosLista.Count;
            var numerosOrderInversa = numerosLista.OrderByDescending(n => n).ToList();

            // POO
            var video = new Video("Live de Aquecimento - Bootcamp", "Uma live daora", new DateTime(2021, 2, 21));
            video.AdicionarVisualizacao();

            Video episodio = new EpisodioSerie(
                "Serie top da Live de Aquecimento",
                "Uma live daora",
                new DateTime(2021, 2, 21),
                0,
                2,
                "Bootcamp ASPNET Core");

            episodio.AdicionarVisualizacao();

            Video documentario = new Documentario("Documentario do C#", "Este é um documentario criado em 2021, etc etc", new DateTime(2021, 2, 20));

            Console.WriteLine();

            Console.WriteLine(MostrarResumo(episodio));
            Console.WriteLine(MostrarResumo(documentario));

            Console.Read();
        }

        public static string MostrarResumo(Video video)
        {
            return video.ObterPreviewResumo();
        }
    }
}
