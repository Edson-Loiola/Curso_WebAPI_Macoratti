using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalago.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }

        //informando ao EF-Core que uma categoria possuí uma coleção de produtos
        //mapeando os relacioamentos
        public ICollection<Produto> Produtos { get; set; }


        //construtor
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        




    }
}
