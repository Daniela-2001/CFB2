namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB cursos");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}