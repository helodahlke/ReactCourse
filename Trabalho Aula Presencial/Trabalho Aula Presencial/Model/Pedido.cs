using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Trabalho_Aula_Presencial.Model
{
    [Table("Pedidos")]
    class Pedido
    {
        [Key]
        public String Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public String Fornecedor { get; set; }

    }

      
}
       

