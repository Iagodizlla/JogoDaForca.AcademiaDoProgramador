namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________");
            Console.WriteLine("Jogo da forca");
            Console.WriteLine("-------------\n");

            string palavraSecreta = "Among-Us";
            string palavraDescoberta = "_";
            Console.WriteLine("A palavra secreta é: ");
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                Console.Write(palavraDescoberta);
            }

            Console.ReadLine();
        }
    }
}
