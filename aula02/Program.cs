namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB cursos"); //C# no padrão .net     Imiprimir CFB Cursos
           
            if (args.GetLength(0) > 0) //O if só está sendo usado para previnir algum problema
            {
                Console.Write(args.GetValue(0)); //Quero obter o índice da posição 0
            }
        }
    }
}