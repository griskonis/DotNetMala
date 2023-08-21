namespace PetCareCliAPI.Models.Reponse
{
    /// <summary>
    /// Tabela Cli do BD
    /// </summary>
    public class TutorReponse
    {
        public string? NOME { get; set; }               // Nome do Tutor
        public string? CPF { get; set; }                // CPF/CNPJ/RNM
        public string? ENDERECO { get; set; }           // Endereço
        public string? CEP { get; set; }                // CEP
        public string? CIDADE { get; set; }             // Cidade
        public string? UF { get; set; }                 // UF
        public string? TEL_RES { get; set; }            // Telefone Residencial
        public string? TEL_COM { get; set; }            // Telefone Comercial
        public string? TEL_CEL { get; set; }            // Telefone Celular
        public string? SIT { get; set; }                // Situacão (Controle Interno)
        public string? EMAIL { get; set; }              // e-mail
        public string? CONJUGE { get; set; }            // Nome do Conjugue
        public string? RESP { get; set; }               // Responsável 1
        public string? RESP2 { get; set; }              // Responsável 2
        public DateTime? DATA_CAD { get; set; }          // Data de Cadastro
        public string? INDICACAO { get; set; }          // Indicação do cliente (Controle Interno)
        public string? ENV_NEWS { get; set; }           // Aceita receber Noticias (S/N)
        public string? CLASSIFICACAO { get; set; }      // Classificação de Origem do Cliente (Controle Interno)
        public double CREDITO { get; set; }             // Valor de Crédito (Controle Interno)
        public DateTime? DT_ULTIMA_INTER { get; set; }   // Data da Última Internação
        public int ORIGEM { get; set; }                 // Código de ORIGEM (Controle Interno)
        public string? OBS { get; set; }                // Observações do Tutor
        public DateTime? DATA_ATUALIZACAO { get; set; }  // Data de Atualização
        public DateTime? DT_NASC { get; set; }           // Data de Nascimento
        public string? SEXO { get; set; }               // Gênero do Tutor
        public int EMPRESAMIGRADA { get; set; }         // Codigo Empresa Migrada
        public DateTime? DATAMIGRADA { get; set; }       // Data Migrada
        public int CODPAR { get; set; }
        public int STATUSREGISTRO { get; set; }         // Status Registro
    }
}

