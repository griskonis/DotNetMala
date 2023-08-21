using PetCareCliAPI.Interfaces;
using System.Runtime.Serialization;

namespace PetCareCliAPI.Helpers
{
    public class ApiHelper: IAPIHelper
    {
        #region Mensagens

        /// <summary>
        /// Tutor não encontrado
        /// </summary>
        public const string TUTOR_NOT_FOUND = "TUTOR NÃO ENCONTRADO";

        /// <summary>
        /// CPF não informado
        /// </summary>
        public const string CPF_NOT_INFORMED = "CPF não informado!";

        /// <summary>
        /// Código do pet não informado
        /// </summary>
        public const string COD_PET_NOT_INFORMED = "Código pet não informado!";

        /// <summary>
        /// Animal não encontrado
        /// </summary>
        public const string PET_NOT_FOUND = "Animal não encontrado";

        /// <summary>
        /// Especialidade não encontrada
        /// </summary>
        public const string SPECIALTY_NOT_FOUND = "Especialidade não encontrada";

        /// <summary>
        /// Especialidade não encontrada
        /// </summary>
        public const string COD_SPECIALTY_NOT_INFORMED = "Código da especialidade não informado!";

        /// <summary>
        /// Unidade(Empresa) não encontrada
        /// </summary>
        public const string COD_UNIT_NOT_INFORMED = "Código da unidade não informado!";

        /// <summary>
        /// Unidade não encontrada
        /// </summary>
        public const string UNIT_NOT_FOUND = "Unidade não encontrada";

        /// <summary>
        /// Inicio do serviço
        /// </summary>
        public const string START_OF_SERVICE = "Inicio do serviço: ";

        /// <summary>
        /// Fim do serviço
        /// </summary>
        public const string END_OF_SERVICE = "Fim do serviço: ";

        #endregion

        #region Querys

        /// <summary>
        /// Lista Tutores - Limitado em 10 registros
        /// </summary>
        public const string QRY_LIST_TUTORS = @"SELECT * FROM CLI.CLI LIMIT 0, 10;";

        /// <summary>
        /// Lista tutor por CPF
        /// </summary>
        public const string QRY_LIST_TUTOR = @"SELECT * FROM CLI.CLI WHERE CPF = ";

        /// <summary>
        /// Lista Pets - Limitado em 10 registros
        /// </summary>
        public const string QRY_LIST_PETS = @"SELECT * FROM CLI.ANIMAIS LIMIT 0, 10;";

        /// <summary>
        /// Lista Pets por código
        /// </summary>
        public const string QRY_LIST_PET = @"SELECT * FROM CLI.ANIMAIS WHERE CODIGO = ";

        /// <summary>
        /// Lista Especialidades por id
        /// </summary>
        public const string QRY_LIST_SPECIALTY = @"SELECT * FROM CLI.USUARIOS_ESPECIALIDADES WHERE ID = ";

        /// <summary>
        /// Lista Especialidades - Limitado em 10 registros
        /// </summary>
        public const string QRY_LIST_SPECIALTYS = @"SELECT * FROM CLI.USUARIOS_ESPECIALIDADES LIMIT 0, 10;";

        /// <summary>
        /// Lista Unidades(empresas) por idEmp
        /// </summary>
        public const string QRY_LIST_UNIT = @"SELECT * FROM CLI.EMPRESAS WHERE ID_EMP = ";

        /// <summary>
        /// Lista Unidades(empresas) - Limitado em 10 registros
        /// </summary>
        public const string QRY_LIST_UNITS = @"SELECT * FROM CLI.EMPRESAS LIMIT 0, 10;";

        #endregion

        /// <summary>
        /// Formata CPF - Removendo ponto e traço
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public string FormatForNoDotCPF(string cpf)
        {
            string formatCPF = cpf.Replace(".", "").Replace("-", "");
            return formatCPF;
        }
    }
}
