using APICatalago.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalago.Context
{
    public class AppDbContext : DbContext  //meu context precisa herdar de DbContext
    {
        
        //mapeamento das entidades
        public DbSet <Categoria> Categorias { get; set; } //a minha entidade Categoria está mapeada com uma entidade Categorias
        public DbSet<Produto> Produtos { get; set; }


        //constutor
        // representa uma sessão com banco de dados
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }


    }
}
