using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.PDF.WEB.Models
{
    public class ReservasViewModel
    {
        public IEnumerable Produtos { get; set; }
        public string TotalCarrinho { get; set; }
        public string Mensagem { get; set; }

    }
}