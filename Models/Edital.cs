using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApredizadoApp.Models
{
    public class Edital
    {
        public int ID { get; set; }
        public int Numero { get; set; }
        public int Ano { get; set; }
        public int Vigencia { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataPublicacao { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataValidade { get; set; }
        
        [DataType(DataType.MultilineText)]
        public object Objeto { get; set; }

        public string Status { get; set; }

        public string NumeroEdital { get; set; }

        public int EntidadeId { get; set; }
    }
}

