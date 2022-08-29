using System.Collections.Generic;
namespace GeradoresDeMassa.Helpers
{
    public class Arquivo
    {
        private static StreamWriter? sw;
        private static string _path = @"C:\Users\robso\OneDrive\Projetos\GeradoresDeMassa\Scripts\";
        private static void CriarArquivoInserts(string pathArquivo)
        {
            try
            {
                using (sw = File.CreateText(pathArquivo))
                {
                    sw.WriteLine("--INSERTS");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EscreverInserts<T>(List<T> listaInserts, string nomeArquivo)
        {
            string pathArquivo = $"{_path}{nomeArquivo}.sql";
            try
            {
                if (!File.Exists(pathArquivo))
                    CriarArquivoInserts(pathArquivo);

                using (sw = File.AppendText(pathArquivo))
                {
                    for(int i = 0; i < listaInserts.Count; i++)
                    {
                        sw.WriteLine($"{listaInserts[i]}");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
