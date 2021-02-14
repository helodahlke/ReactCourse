using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Aula_Presencial.Model
{
    

 
        //Microsoft.EntityFrameowrkCore.SqlServer
        //Microsoft.EntityFrameowrkCore.Tools

        //Add-Migration NomeMigracao
        //Update-Database -verbose
        class Context : DbContext
        {
            public DbSet<Pedido> Pedidos { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UsuariosDb;
                Trusted_Connection=true");
            }

        }
}

