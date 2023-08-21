using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Interfaces
{
    public interface IPet
    {
        Task<IEnumerable<PetResponse>> GetPetsAsync();
        Task<PetResponse> GetPetAsync(int codigo);
    }
}
