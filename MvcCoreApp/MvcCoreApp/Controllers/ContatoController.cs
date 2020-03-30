using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreApp.Libary.Mail;
using MvcCoreApp.Models;

namespace MvcCoreApp.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}",
                //    contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

                //return new ContentResult() { Content = conteudo };
                
                EnviarEmail.EnviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso!";
                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }

        //public IActionResult ReceberContato()
        //{
        //    //POST - Request.Form["nome"]
        //    //GET - Request.Query/Request.QueryString

        //    Contato contato = new Contato() { 
        //        Nome = Request.Form["nome"],
        //        Email = Request.Form["email"],
        //        Assunto = Request.Form["assunto"],
        //        Mensagem = Request.Form["mensagem"]
        //    };

        //    string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}",
        //        contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

        //    return new ContentResult() { Content = conteudo };
        //}
    }
}