using MvcCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MvcCoreApp.Libary.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1}<br /> Assunto: {2}<br /> Mensagem: {3}", 
                contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //Para enviar um email é necessário duas etapas:
            //ConfigurarSMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false; // verificar servico email Pegasus!
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            //Mensagem de email
            MailMessage mensagem = new MailMessage();
            
            mensagem.From = new MailAddress("caio.tf2@gmail.com");
            mensagem.To.Add("caiotfgv@hotmail.com");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de contato</h1> " + conteudo;

            smtp.Send(mensagem);
        }
    }
}
