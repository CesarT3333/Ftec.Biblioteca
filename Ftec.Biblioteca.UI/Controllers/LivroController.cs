using System;
using Ftec.Biblioteca.UI.BLL;
using Ftec.Biblioteca.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ftec.Biblioteca.UI.Controllers
{
    // https://localhost:5001/Livro/Index
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            var bLivro = new BLivro();
            var listaLivros = bLivro.RetornarLivros();

            ViewBag.livros = listaLivros;

            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult Editar(Int64 id)
        {

            var bLivro = new BLivro();
            var livro = bLivro.buscarPorId(id);
            
            ViewBag.livro = livro;

            return View();
        }

//        [HttpPost]
//        public ActionResult ProcessarGravacaoPost(Livro livro)
//        {
//            
//            var bLivro = new BLivro();
//            bLivro.cadastrarLivro(livro);
//            
//
//            return RedirectToAction("Index");
//        }

//        [HttpPost]
//        public ActionResult ProcessarUpdatePost(Livro livro)
//        {
//            var livros = GetListaLivros();
//
//            var livroAntigo = livros.FirstOrDefault(l => l.Id == livro.Id); //lambda expression
//
//            //remove a versao anterior do livro
//            //insere a nova versao
//            livros.Remove(livroAntigo);
//            livros.Add(livro);
//
//            Session["livros"] = livros;
//
//            return RedirectToAction("Index");
//        }
    }
}