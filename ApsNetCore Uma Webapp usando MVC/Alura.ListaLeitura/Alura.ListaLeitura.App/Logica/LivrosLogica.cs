using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {
        public IActionResult ParaLer()
        {
            ViewBag.Livros = new LivroRepositorioCSV().ParaLer.Livros;
            return View ("para-ler");
        }

        public IActionResult Lendo()
        {
            ViewBag.Livros = new LivroRepositorioCSV().Lendo.Livros;
            return View("livros-lendo");
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Detalhes = new LivroRepositorioCSV().Todos.First(l => l.Id == id).Detalhes();
            return View("livro-detalhes");
        } 

        public string Lidos() => new LivroRepositorioCSV().Lidos.ToString();

        public string Teste() => "Uma nova funcionalidade foi implementada!";
    }
}
