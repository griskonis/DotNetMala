using Dapper;
using MySqlConnector;
using PetCareCliAPI.Helpers;
using PetCareCliAPI.Interfaces;
using PetCareCliAPI.Models.Reponse;
using System.Diagnostics.CodeAnalysis;

namespace PetCareCliAPI.Repositorys
{
    public class TutorRepository : ITutor
    {
        private readonly IConfiguration _configuration;
        private readonly string? connectionstring;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="configuration"></param>
        public TutorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionstring = _configuration.GetConnectionString("MySqlConnection");
        }

        /// <summary>
        /// GetTutorsAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TutorReponse>> GetTutorsAsync()
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryAsync<TutorReponse>(ApiHelper.QRY_LIST_TUTORS);
        }

        /// <summary>
        /// GetTutorAsync
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public async Task<TutorReponse> GetTutorAsync(string cpf)
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryFirstOrDefaultAsync<TutorReponse>(string.Concat(ApiHelper.QRY_LIST_TUTOR, cpf, ";"));
        }
    }
}
