
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Logica
{
    public class CadastroController
    {
        public string Incluir(Livro livro)
        {
            new LivroRepositorioCSV().Incluir(livro);
            return "O livro foi adicionado com sucesso";
        }

        public IActionResult ExibeFormulario() => new ViewResult { ViewName = "formulario" };
    }
}
