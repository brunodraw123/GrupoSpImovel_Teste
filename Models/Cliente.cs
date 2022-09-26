using System;
using System.Collections.Generic;

namespace Gerenciamento_Clientes.Models
{
    public partial class Cliente
    {
        //Model criado a partir do modela de tabela do Banco de dados (Database First/ Egenharia Reversa EF)
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
