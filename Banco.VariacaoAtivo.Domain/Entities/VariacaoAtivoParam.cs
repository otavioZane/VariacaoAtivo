using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.VariacaoAtivo.Domain.Entities {
    public class VariacaoAtivoParam {

        public VariacaoAtivoParam()
        {
            
        }

        public int Day { get; set; }
        public DateOnly Date { get; set; }
        public decimal Value { get; set; }
        public decimal VariationFirstDate { get; set; }
        public decimal VariationRelationD1 { get; set; }
    }
}
