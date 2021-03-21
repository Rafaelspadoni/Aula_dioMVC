using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_dio.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        

        public int quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria {get; set;}

    }
}
