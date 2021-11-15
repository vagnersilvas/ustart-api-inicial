using System;

namespace UStart.Domain.Commands
{
    public class ClienteCommand
    {
        public Guid Id { get; private set; }
        public Guid? ImovelId { get; private set; }
        public string Nome { get; private set; }
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public string CPF { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string EstadoId { get; private set; }
        public string CidadeId { get; private set; }
        public string CidadeNome { get; private set; }
        public string CEP { get; private set; }
        public string Fone { get; private set; }
        public string Email { get; private set; }

    }
}