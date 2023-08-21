using Dapper;
using MySqlConnector;
using PetCareCliAPI.Helpers;
using PetCareCliAPI.Interfaces;
using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Repositorys
{
    public class PetRepository : IPet
    {
        private readonly IConfiguration _configuration;
        private readonly string? connectionstring;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="configuration"></param>
        public PetRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionstring = _configuration.GetConnectionString("MySqlConnection");
        }

        /// <summary>
        /// GetPetAsync
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public async Task<PetResponse> GetPetAsync(int codigo)
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryFirstOrDefaultAsync<PetResponse>(string.Concat(ApiHelper.QRY_LIST_PET, codigo, ";"));
        }

        /// <summary>
        /// GetPetsAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PetResponse>> GetPetsAsync()
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryAsync<PetResponse>(ApiHelper.QRY_LIST_PETS);
        }
    }
}
