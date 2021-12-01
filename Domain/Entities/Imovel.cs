using System;
using UStart.Domain.Commands;

namespace UStart.Domain.Entities
{
    public class Imovel
    {
        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
        public String TipoImovel { get; private set; }
        public string UrlImagem { get; private set; }
        public String Rua { get; private set; }
        public String Numero { get; private set; }
        public String Complemento { get; private set; }
        public String Bairro { get; private set; }
        public String CEP { get; private set; }
        public String EstadoId { get; private set; }
        public String CidadeId { get; private set; }
        public String CidadeNome { get; private set; }
        public String Descricao { get; private set; }
        public String Finalidade { get; private set; }
        public String Situacao { get; private set; }
        public Decimal AreaConstruida { get; private set; }
        public Decimal AreaTotal { get; private set; }
        public Decimal ValorVenda { get; private set; }
        public Decimal ValorAluguel { get; private set; }
        public Decimal Dormitorios { get; private set; }
        public Decimal Suite { get; private set; }
        public Decimal VagasGaragem { get; private set; }

        public Imovel()
        {

        }

        public Imovel(ImovelCommand command)
        {
            Id = command.Id == Guid.Empty ? Guid.NewGuid() : command.Id;
            AtualizarCampos(command);
        }

        public void Update(ImovelCommand command)
        {
            AtualizarCampos(command);
        }

        private void AtualizarCampos(ImovelCommand command)
        {
            ClienteId = command.ClienteId;
            UsuarioId = command.UsuarioId.HasValue ? command.UsuarioId.Value : Guid.Empty;
            Rua = command.Rua;
            Numero = command.Numero;
            Complemento = command.Complemento;
            Bairro = command.Bairro;
            CidadeId = command.CidadeId;
            CidadeNome = command.CidadeNome;
            CEP = command.CEP;
            TipoImovel = command.TipoImovel;
            Finalidade = command.Finalidade;
            Situacao = command.Situacao;
            Descricao = command.Descricao;
            AreaConstruida = command.AreaConstruida;
            AreaTotal = command.AreaTotal;
            ValorVenda = command.ValorVenda;
            ValorAluguel = command.ValorAluguel;
            Dormitorios = command.Dormitorios;
            UrlImagem = command.UrlImagem;
            Suite = command.Suite;
            VagasGaragem = command.VagasGaragem;
        }

    }

}
