namespace PagosTc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codigo = DateTime.Now.ToString("yymmss");
            Console.WriteLine(codigo);

            Console.WriteLine("Introduce tu codigo de verificacion");
            string codigoEscrito = Console.ReadLine();

            if (codigoEscrito == codigo)
            {
                Console.WriteLine("ok");
            }

        }
    }
}
