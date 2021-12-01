using System;
using System.Collections.Generic;
using System.Linq;
using UStart.Domain.Entities;

namespace UStart.Domain.Results
{
    public class ImovelResult
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid UsuarioId { get; set; }
        public UsuarioResult Usuario { get; set; }
         public String TipoImovel { get;  set; }
        public string UrlImagem { get;  set; }
        public String Rua { get;  set; }
        public String Numero { get;  set; }
        public String Complemento { get;  set; }
        public String Bairro { get;  set; }
        public String CEP { get;  set; }
        public String EstadoId { get;  set; }
        public String CidadeId { get;  set; }
        public String CidadeNome { get;  set; }
        public String Descricao { get;  set; }
        public String Finalidade { get;  set; }
        public String Situacao { get;  set; }
        public Decimal AreaConstruida { get;  set; }
        public Decimal AreaTotal { get;  set; }
        public Decimal ValorVenda { get;  set; }
        public Decimal ValorAluguel { get;  set; }
        public Decimal Dormitorios { get;  set; }
        public Decimal Suite { get;  set; }
        public Decimal VagasGaragem { get;  set; }
        public ImovelResult(Imovel imovel)
        {
            if (imovel == null)
            {
                return;
            }

            this.Id = imovel.Id;
            this.ClienteId = imovel.ClienteId;
            this.Cliente = imovel.Cliente;
            this.UsuarioId = imovel.UsuarioId;
            this.Usuario = new UsuarioResult(imovel.Usuario);
            this.TipoImovel = imovel.TipoImovel;
            this.UrlImagem = imovel.UrlImagem;
            this.Rua = imovel.Rua;
            this.Numero = imovel.Numero;
            this.Complemento = imovel.Complemento;
            this.Bairro = imovel.Bairro;
            this.CEP = imovel.CEP;
            this.EstadoId = imovel.EstadoId;
            this.CidadeId = imovel.CidadeId;
            this.CidadeNome = imovel.CidadeNome;
            this.Descricao = imovel.Descricao;
            this.Finalidade = imovel.Finalidade;
            this.Situacao = imovel.Situacao;
            this.AreaConstruida = imovel.AreaConstruida;
            this.AreaTotal = imovel.AreaTotal;
            this.ValorVenda = imovel.ValorVenda;
            this.ValorAluguel = imovel.ValorAluguel;
            this.Dormitorios = imovel.Dormitorios;
            this.Suite = imovel.Suite;
            this.VagasGaragem = imovel.VagasGaragem;
        
        }
    }
}