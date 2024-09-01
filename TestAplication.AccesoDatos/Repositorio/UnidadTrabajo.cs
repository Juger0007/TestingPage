using TestAplication.AccesoDatos.Data;
using TestAplication.AccesoDatos.Repositorio.IRepositorio;
using TestAplication.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Rewrite;

namespace TestAplication.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
