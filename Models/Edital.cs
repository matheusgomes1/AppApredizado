using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApredizadoApp.Models
{
    public class Edital
    {
        public int Id { get; set; }
        public int numero { get; set; }
        public int ano { get; set; }
        public int vigencia { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataPublicacao { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataValidade { get; set; }
        
        [DataType(DataType.MultilineText)]
        public object objeto { get; set; }

        public string status { get; set; }

        public string numeroEdital { get; set; }

        public int entidadeId { get; set; }
    }
}

