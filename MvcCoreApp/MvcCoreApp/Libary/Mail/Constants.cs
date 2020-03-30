using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApp.Libary.Mail
{
    public class Constants
    {
        //POP3, IMAP - Protocolos de entrada (permitem ler mensagens de e-mail)
        //SMTP - Protocolo de saída (permite enviar e-mail)

        //Necessário 4 dados para enviar email:
        //Autenticação - Gmail
        public readonly static string Usuario = "caio.tf2@gmail.com";
        public readonly static string Senha = "";

        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;

    }
}
