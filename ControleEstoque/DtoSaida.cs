using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    [Table("saida", Schema = "public")]
    public class DtoSaida
    {
        [Key]

        public int idsaida { get; set; }
        public int idproduto { get; set; }
        public decimal qtdeproduto { get; set; }
        public decimal valorcustoproduto { get; set; }
        public decimal valortotalproduto { get; set; }
        public DateTime dtcompra { get; set; }
        public string nomeproduto { get; set; }
    }
}