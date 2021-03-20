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

        public string descricao { get; set; }
        [Display(Name = "Descrição")]

        public int quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria {get; set;}

    }
}
