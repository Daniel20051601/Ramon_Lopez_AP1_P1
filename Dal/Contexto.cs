using Microsoft.EntityFrameworkCore;
using Ramon_Lopez_AP1_P1.Models;

namespace Ramon_Lopez_AP1_P1.Dal;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Registro> Registros { get; set; }

    public Contexto() { }
}
