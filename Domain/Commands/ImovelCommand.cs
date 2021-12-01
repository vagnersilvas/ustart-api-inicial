using System;
using UStart.Domain.Entities;

namespace UStart.Domain.Commands
{
    public class ImovelCommand
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Guid? UsuarioId { get; set; }        
        public String TipoImovel { get; set; }
        public string UrlImagem { get;  set; }
        public String Rua { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public String EstadoId { get; set; }
        public String CidadeId { get; set; }
        public String CidadeNome { get; set; }
        public String Descricao { get; set; }
        public String Finalidade { get; set; }
        public String Situacao { get; set; }
        public Decimal AreaConstruida { get; set; }
        public Decimal AreaTotal { get; set; }
        public Decimal ValorVenda { get; set; }
        public Decimal ValorAluguel { get; set; }
        public Decimal Dormitorios { get; set; }
        public Decimal Suite { get; set; }
        public Decimal VagasGaragem { get; set; }

    }
}