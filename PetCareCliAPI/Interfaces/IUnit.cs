using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Interfaces
{
    public interface IUnit
    {
        Task<IEnumerable<UnitResponse>> GetUnitsAsync();
        Task<UnitResponse> GetUnitAsync(int idEmp);
    }
}
