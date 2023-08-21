using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Interfaces
{
    public interface ITutor
    {
        Task<IEnumerable<TutorReponse>> GetTutorsAsync();
        Task<TutorReponse> GetTutorAsync(string cpf);
    }
}
