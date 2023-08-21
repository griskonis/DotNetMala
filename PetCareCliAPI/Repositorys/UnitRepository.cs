using Dapper;
using MySqlConnector;
using PetCareCliAPI.Helpers;
using PetCareCliAPI.Interfaces;
using PetCareCliAPI.Models.Reponse;

namespace PetCareCliAPI.Repositorys
{
    public class UnitRepository : IUnit
    {
        private readonly IConfiguration _configuration;
        private readonly string? connectionstring;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="configuration"></param>
        public UnitRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionstring = _configuration.GetConnectionString("MySqlConnection");
        }

        /// <summary>
        /// GetUnitAsync
        /// </summary>
        /// <param name="idEmp"></param>
        /// <returns></returns>
        public async Task<UnitResponse> GetUnitAsync(int idEmp)
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryFirstOrDefaultAsync<UnitResponse>(string.Concat(ApiHelper.QRY_LIST_UNIT, idEmp, ";"));
        }

        /// <summary>
        /// GetUnitsAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UnitResponse>> GetUnitsAsync()
        {
            using var conn = new MySqlConnection(connectionstring);
            return await conn.QueryAsync<UnitResponse>(ApiHelper.QRY_LIST_UNITS);
        }
    }
}
