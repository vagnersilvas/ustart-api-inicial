﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UStart.Infrastructure.Context;

namespace UStart.Infrastructure.Migrations
{
    [DbContext(typeof(UStartContext))]
    partial class UStartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("UStart.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("CPF")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("CidadeId")
                        .HasColumnType("text")
                        .HasColumnName("cidade_id");

                    b.Property<string>("CidadeNome")
                        .HasColumnType("text")
                        .HasColumnName("cidade_nome");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("EstadoId")
                        .HasColumnType("text")
                        .HasColumnName("estado_id");

                    b.Property<string>("Fone")
                        .HasColumnType("text")
                        .HasColumnName("fone");

                    b.Property<Guid>("ImovelId")
                        .HasColumnType("uuid")
                        .HasColumnName("imovel_id");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .HasColumnType("text")
                        .HasColumnName("numero");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text")
                        .HasColumnName("razao_social");

                    b.Property<string>("Rua")
                        .HasColumnType("text")
                        .HasColumnName("rua");

                    b.HasKey("Id")
                        .HasName("pk_clientes");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Imovel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<decimal>("AreaConstruida")
                        .HasColumnType("numeric")
                        .HasColumnName("area_construida");

                    b.Property<decimal>("AreaTotal")
                        .HasColumnType("numeric")
                        .HasColumnName("area_total");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CidadeId")
                        .HasColumnType("text")
                        .HasColumnName("cidade_id");

                    b.Property<string>("CidadeNome")
                        .HasColumnType("text")
                        .HasColumnName("cidade_nome");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid")
                        .HasColumnName("cliente_id");

                    b.Property<Guid?>("ClienteId1")
                        .HasColumnType("uuid")
                        .HasColumnName("cliente_id1");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<decimal>("Dormitorios")
                        .HasColumnType("numeric")
                        .HasColumnName("dormitorios");

                    b.Property<string>("EstadoId")
                        .HasColumnType("text")
                        .HasColumnName("estado_id");

                    b.Property<string>("Finalidade")
                        .HasColumnType("text")
                        .HasColumnName("finalidade");

                    b.Property<string>("Numero")
                        .HasColumnType("text")
                        .HasColumnName("numero");

                    b.Property<string>("Rua")
                        .HasColumnType("text")
                        .HasColumnName("rua");

                    b.Property<string>("Situacao")
                        .HasColumnType("text")
                        .HasColumnName("situacao");

                    b.Property<decimal>("Suite")
                        .HasColumnType("numeric")
                        .HasColumnName("suite");

                    b.Property<string>("TipoImovel")
                        .HasColumnType("text")
                        .HasColumnName("tipo_imovel");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("text")
                        .HasColumnName("url_imagem");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("usuario_id");

                    b.Property<decimal>("VagasGaragem")
                        .HasColumnType("numeric")
                        .HasColumnName("vagas_garagem");

                    b.Property<decimal>("ValorAluguel")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_aluguel");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_venda");

                    b.HasKey("Id")
                        .HasName("pk_imoveis");

                    b.HasIndex("ClienteId1")
                        .HasDatabaseName("ix_imoveis_cliente_id1");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_imoveis_usuario_id");

                    b.ToTable("imoveis");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Autenticacao")
                        .HasColumnType("text")
                        .HasColumnName("autenticacao");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_registro");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_usuarios");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Imovel", b =>
                {
                    b.HasOne("UStart.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1")
                        .HasConstraintName("fk_imoveis_clientes_cliente_id1");

                    b.HasOne("UStart.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_imoveis_usuarios_usuario_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
