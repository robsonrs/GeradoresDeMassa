using GeradoresDeMassa.Geradores;
internal class Program
{
    private static void Main(string[] args)
    {
        Cpf.CriarListaInsertsCpf(100000);
        Console.WriteLine("Geração de CPFs finalizada!");
    }
}