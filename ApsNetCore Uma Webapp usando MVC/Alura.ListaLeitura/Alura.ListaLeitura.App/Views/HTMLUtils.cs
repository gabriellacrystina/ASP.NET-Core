
using System.IO;

namespace Alura.ListaLeitura.App.HTML
{
    public static class HTMLUtils
    {
        public static string CarregaArquivoHTML(string nomeArquivo)
        {
            var nomeCompletoArquivo = $@"C:\Users\Gabriella\Desktop\Alura\ApsNetCore Uma Webapp usando MVC\Alura.ListaLeitura\Alura.ListaLeitura.App\HTML\{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
