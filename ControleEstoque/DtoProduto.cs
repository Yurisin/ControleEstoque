using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
[Table("produto", Schema = "public")]
    public class DtoProduto
    {
        [Key]

        public int id { get; set; }
        public string nome { get; set; }    
        public decimal? valorvenda { get; set; }
        public decimal? valorcusto { get; set; }
        public string unidade {get; set; }
        public decimal quantidade { get; set; }

    }
}