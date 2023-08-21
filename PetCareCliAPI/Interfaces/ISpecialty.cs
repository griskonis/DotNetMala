using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Interfaces
{
    public interface ISpecialty
    {
        Task<IEnumerable<SpecialtyResponse>> GetSpecialtysAsync();
        Task<SpecialtyResponse> GetSpecialtyAsync(int id);
    }
}
