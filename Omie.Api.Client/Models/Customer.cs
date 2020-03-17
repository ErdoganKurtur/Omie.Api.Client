using Newtonsoft.Json;
using Omie.Api.Client.Abstractions;
using System.Collections.Generic;

namespace Omie.Api.Client.Models {
    /// <remarks/>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Customer : IRequestParameter {
        /// <remarks/>
        [JsonProperty("codigo_cliente_omie")]
        public int? Id { get; set; }

        /// <remarks/>
        [JsonProperty("bairro")]
        public string Neighborhood { get; set; }

        /// <remarks/>
        [JsonProperty("bloquear_faturamento")]
        public string BlockBilling { get; set; }

        /// <remarks/>
        [JsonProperty("cep")]
        public string PostalCode { get; set; }

        /// <remarks/>
        [JsonProperty("cidade")]
        public string City { get; set; }

        /// <remarks/>
        [JsonProperty("cidade_ibge")]
        public string CityIbgeId { get; set; }

        /// <remarks/>
        [JsonProperty("cnpj_cpf")]
        public string CnpjCpf { get; set; }

        /// <remarks/>
        [JsonProperty("codigo_cliente_integracao")]
        public string IntegrationId { get; set; }

        /// <remarks/>
        [JsonProperty("codigo_pais")]
        public string CountryId { get; set; }

        /// <remarks/>
        [JsonProperty("complemento")]
        public string ComplementaryAddress { get; set; }

        /// <remarks/>
        [JsonProperty("contato")]
        public string Contact { get; set; }

        /// <remarks/>
        [JsonProperty("endereco")]
        public string Address { get; set; }

        /// <remarks/>
        [JsonProperty("endereco_numero")]
        public string AddressNumber { get; set; }

        /// <remarks/>
        [JsonProperty("estado")]
        public string State { get; set; }

        /// <remarks/>
        [JsonProperty("exterior")]
        public string International { get; set; }

        /// <remarks/>
        [JsonProperty("inativo")]
        public string Inactive { get; set; }

        /// <remarks/>
        [JsonProperty("info")]
        public Info Info { get; set; }

        /// <remarks/>
        [JsonProperty("inscricao_estadual")]
        public string StateRegistration { get; set; }

        /// <remarks/>
        [JsonProperty("inscricao_municipal")]
        public string MunicipalRegistration { get; set; }

        /// <remarks/>
        [JsonProperty("nome_fantasia")]
        public string BusinessName { get; set; }

        /// <remarks/>
        [JsonProperty("observacao")]
        public string Observation { get; set; }

        /// <remarks/>
        [JsonProperty("pessoa_fisica")]
        public string IsFisicalPerson { get; set; }

        /// <remarks/>
        [JsonProperty("razao_social")]
        public string CorporateName { get; set; }

        /// <remarks/>
        [JsonProperty("tags")]
        public IEnumerable<Tag> Tags { get; set; }

        /// <remarks/>
        [JsonProperty("telefone1_ddd")]
        public string Phone1Prefix { get; set; }

        /// <remarks/>
        [JsonProperty("telefone1_numero")]
        public string Phone1Number { get; set; }

        /// <remarks/>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <remarks/>
        [JsonProperty("telefone2_ddd")]
        public string Phone2Prefix { get; set; }

        /// <remarks/>
        [JsonProperty("telefone2_numero")]
        public string Phone2Number { get; set; }
    }
}
