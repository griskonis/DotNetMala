namespace PetCareCliAPI.Models.Reponse
{
    public class UnitResponse
    {
        /// <summary>
        /// Tabela empresas
        /// </summary>
        public int ID_EMP {get; set; }                          // Código da Unidade ou Empresa
        public string? RZ_SOCIAL { get; set; }                  // Razão Social
        public string? NM_FANTASIA { get; set; }                // Nome Fantasia
        public string? CNPJ { get; set; }                       // CNPF
        public string? INSCRICAO_ESTADUAL { get; set; }         // INSCRICAO ESTADUAL
        public string? TP_LOGRADOURO { get; set; } 
        public string? LOGRADOURO { get; set; } 
        public string? NUMERO { get; set; } 
        public string? COMPLEMENTO { get; set; } 
        public int ID_GRUPO_EMPRESA { get; set; } 
        public string? APELIDO_EMP { get; set; } 
        public string? COR_EMP { get; set; } 
        public string? EMPRESAS_PREFERENCIAIS { get; set; } 
        public string? BAIRRO { get; set; } 
        public string? COD_MUNICIPIO { get; set; } 
        public string? CEP { get; set; } 
        public string? INSCRICAO_MUNICIPAL { get; set; } 
        public string? EMAIL { get; set; } 
        public string? TELEFONE { get; set; } 
        public string? OPTANTE_SIMPLES { get; set; } 
        public string? EMAIL_XML { get; set; } 
        public string? SERIE_NFE { get; set; } 
        public int NUM_NFE { get; set; } 
        public string? TIPO_EMPRESA { get; set; } 
        public int ID_ULTIMO_RECIBO { get; set; } 
        public string? SENHA_EMP { get; set; } 
        public string? CODIGO_SERV_PRESTADO { get; set; } 
        public string? DESCRICAO_SERV { get; set; } 
        public string? FONTE_TRIBUTO { get; set; } 
        public string? OPCOES_RECEB { get; set; } 
        public string? SERIE { get; set; } 
        public string? ALIQUOTA_COD_SERV { get; set; } 
        public string? RPS_OBRIGATORIO { get; set; } 
        public string? ATIVA { get; set; } 
        public string? PERCENTUAL_IR { get; set; } 
        public int IND_PRESENCA_CONS { get; set; } 
        public int IND_MODALIDADE_FRETE { get; set; } 
        public string? LOCAL_MODELOS { get; set; } 
        public string? EMAIL_SMTP { get; set; } 
        public string? EMAIL_PORTA { get; set; } 
        public string? EMAIL_SSL { get; set; } 
        public string? SENHA_SMTP { get; set; } 
        public string? SERV_SMTP { get; set; } 
        public int CLINICA_ID { get; set; } 
        public string? IMPRESSORA_ETIQUETAS { get; set; } 
    }
}
