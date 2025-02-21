﻿// <auto-generated />
using System;
using GestaoPedidos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GestãoPedidos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250108231405_AddAtivoToClientesAndProdutos")]
    partial class AddAtivoToClientesAndProdutos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GestaoPedidos.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("clienteid")
                        .UseIdentityByDefaultColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.HasKey("ClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("GestaoPedidos.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("pedidoid")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer")
                        .HasColumnName("clienteid");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datapedido");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("integer")
                        .HasColumnName("produtoid");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("numeric")
                        .HasColumnName("valortotal");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("GestaoPedidos.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("produtoid")
                        .UseIdentityByDefaultColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric")
                        .HasColumnName("preco");

                    b.HasKey("ProdutoId");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("GestaoPedidos.Models.Pedido", b =>
                {
                    b.HasOne("GestaoPedidos.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPedidos.Models.Produto", "Produto")
                        .WithMany("Pedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("GestaoPedidos.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("GestaoPedidos.Models.Produto", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
