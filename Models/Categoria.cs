using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_dio.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        [Display(Name = "Descrição")]

        public List<Produto> Produtos { get; set; }
    }
}
