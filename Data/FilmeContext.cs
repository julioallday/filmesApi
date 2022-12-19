using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace filmesApi.Data;

public class FilmeContext : DbContext
{
   public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
   {

   } 
    public DbSet<Filme> Filmes { get; set; }
}