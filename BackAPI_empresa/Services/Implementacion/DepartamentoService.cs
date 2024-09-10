using Microsoft.EntityFrameworkCore;
using BackAPI_empresa.Models;
using BackAPI_empresa.Services.Contrato;

namespace BackAPI_empresa.Services.Implementacion
{
    public class DepartamentoService: IDepartamentoService
    {
        private UsercrudContext _dbContext;

        public DepartamentoService(UsercrudContext dbContext) { 
            _dbContext = dbContext;
        }

        public async Task<List<Departamento>> GetList()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                lista = await _dbContext.Departamentos.ToListAsync();
                return lista;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
