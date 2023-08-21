namespace PetCareCliAPI.Models.Reponse
{
    public class PetResponse
    {
        public int CODIGO { get; set; }                     // Código do Animal
        public string? ID { get; set; }         
        public string? NOME_ANI { get; set; }               // Nome do Animal
        public string? SEXO { get; set; }                   // Gênero do Animal (M/F)
        public DateTime? DT_NASC { get; set; }              // Data de Nascimento
        public string? PESO { get; set; }                   // Peso do Animal
        public string? PESO_IDEAL { get; set; }             // Peso ideal do animal
        public string? RACA { get; set; }                   // Descrição da Raça do Animal
        public string? ALERGICO { get; set; }               // Descrição da Alergia
        public string? COR { get; set; }                    // Descrição da Cor
        public string? ESPECIE { get; set; }                // Descrição da Espécie
        public string? RGA { get; set; }                    // Número do Registro Geral do Animal
        public string? MORTO { get; set; }                  // É morto (S/N)
        public string? CASTRADO { get; set; }               // É castrado (S/N)
        public string? OBSERVACOES { get; set; }            // Observações referente ao animal
        public int ORIGEM { get; set; }                     // Código de Origem
        public int CODIGO_ANTIGO { get; set; }
        public string? MIGRADO { get; set; }
        public string? MIGRADO_PESOS { get; set; }
        public string? MIGRADO_RETORNOS { get; set; }
        public string? MIGRADO_LEMBRETES { get; set; }
        public DateTime? DATA_ATUALIZACAO { get; set; }
        public int EMPRESAMIGRADA { get; set; }
        public DateTime? DATAMIGRADA { get; set; }
        public int STATUSREGISTRO { get; set; }
        public int CODCLI { get; set; }
        public int CODVET { get; set; }
        public DateTime? DT_STATUS_MORTO { get; set; }
    }
}
