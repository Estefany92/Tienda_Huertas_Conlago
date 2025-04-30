using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tienda_Huertas_Conlago.Models;

    public class Tienda_Huertas_Conlago_DB : DbContext
    {
        public Tienda_Huertas_Conlago_DB (DbContextOptions<Tienda_Huertas_Conlago_DB> options)
            : base(options)
        {
        }

        public DbSet<Tienda_Huertas_Conlago.Models.Usuario> Usuario { get; set; } = default!;

public DbSet<Tienda_Huertas_Conlago.Models.Pedido> Pedido { get; set; } = default!;

public DbSet<Tienda_Huertas_Conlago.Models.Inventario> Inventario { get; set; } = default!;
    }
