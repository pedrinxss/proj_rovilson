using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_FormValidacao.Models
{
    public class QestController : Controller
    {        public string cod { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [DisplayName("Nome do cliente")]
        public string nome { get; set; }
    }
}