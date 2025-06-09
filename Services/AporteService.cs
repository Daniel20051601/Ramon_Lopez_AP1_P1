using Microsoft.EntityFrameworkCore;
using Ramon_Lopez_AP1_P1.Dal;
using Ramon_Lopez_AP1_P1.Models;
using System.Linq.Expressions;

namespace Ramon_Lopez_AP1_P1.Services;

public class AporteService(IDbContextFactory<Contexto> DbContext)
{
    public async Task<bool> Existe(int ReporteId)
    {
        await using var contexto = await  DbContext.CreateDbContextAsync();
        return await contexto.Aportes.AnyAsync(x => x.AporteId == ReporteId);
    }

    public async Task<bool> Insertar(Aportes aporte)
    {
        await using var contexto = await DbContext.CreateDbContextAsync();
        contexto.Aportes.Add(aporte);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(Aportes aporte)
    {
        await using var contexto = await DbContext.CreateDbContextAsync();
        contexto.Update(aporte);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Aportes aporte)
    {
        if(!await Existe(aporte.AporteId))
        {
            return await Insertar(aporte);
        }
        else
        {
            return await Modificar(aporte);
        }
    }

    public async Task<bool> Eliminar(int aporteId)
    {
        await using var contexto = await DbContext.CreateDbContextAsync();
        return await contexto.Aportes
            .Where(x => x.AporteId == aporteId)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<Aportes?> Buscar(int aporteId)
    {
        await using var contexto = await DbContext.CreateDbContextAsync();
        return await contexto.Aportes.FirstOrDefaultAsync();
    }

    public async Task<List<Aportes>> GetList(Expression<Func<Aportes, bool>> criterio)
    {
        await using var contexto = await DbContext.CreateDbContextAsync();
        return await contexto.Aportes.Where(criterio).ToListAsync();
    }

}
