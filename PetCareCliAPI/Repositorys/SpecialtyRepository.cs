using Dapper;
using MySqlConnector;
using PetCareCliAPI.Helpers;
using PetCareCliAPI.Interfaces;
using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Repositorys
{
    public class SpecialtyRepository : ISpecialty
    {
        private readonly IConfiguration _configuration;
        private readonly string? connectionstring;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="configuration"></param>
        public SpecialtyRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionstring = _configuration.GetConnectionString("MySqlConnection");
        }

        /// <summary>
        /// GetSpecialtyAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SpecialtyResponse> GetSpecialtyAsync(int id)
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryFirstOrDefaultAsync<SpecialtyResponse>(string.Concat(ApiHelper.QRY_LIST_SPECIALTY, id, ";"));
        }

        /// <summary>
        /// GetSpecialtysAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SpecialtyResponse>> GetSpecialtysAsync()
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryAsync<SpecialtyResponse>(ApiHelper.QRY_LIST_SPECIALTYS);
        }
    }
}
