using BackAPI_empresa.Models;

namespace BackAPI_empresa.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}
