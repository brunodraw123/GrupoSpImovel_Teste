using System;
using System.Collections.Generic;

namespace Gerenciamento_Clientes.Models
{
    public partial class Cliente
    {
        public int ClienteId { get; set; }
        public string Cliente1 { get; set; } = null!;
        public string TipoCliente { get; set; } = null!;
        public string NomeContato { get; set; } = null!;
        public string TelefoneContato { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
