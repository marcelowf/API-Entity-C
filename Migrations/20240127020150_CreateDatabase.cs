using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhoFinalEntity.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checkins",
                columns: table => new
                {
                    CodCheckin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(type: "int", nullable: false),
                    StatusCheckIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoPermanecia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkins", x => x.CodCheckin);
                });

            migrationBuilder.CreateTable(
                name: "CheckOuts",
                columns: table => new
                {
                    CodCheckOut = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(type: "int", nullable: false),
                    ValorNotaFiscal = table.Column<float>(type: "real", nullable: false),
                    PagamentoNotaFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOuts", x => x.CodCheckOut);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NacionalidadeCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodCliente);
                });

            migrationBuilder.CreateTable(
                name: "ConsumoFrigobars",
                columns: table => new
                {
                    CodConsumoFrigobar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(type: "int", nullable: false),
                    CodFrigobar = table.Column<int>(type: "int", nullable: false),
                    CodNotaFiscal = table.Column<int>(type: "int", nullable: false),
                    DescricaoConsumo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ValorConsumo = table.Column<float>(type: "real", nullable: false),
                    Assinado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoFrigobars", x => x.CodConsumoFrigobar);
                });

            migrationBuilder.CreateTable(
                name: "ConsumoLavanderias",
                columns: table => new
                {
                    CodConsumoLavanderia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(type: "int", nullable: false),
                    CodLavanderia = table.Column<int>(type: "int", nullable: false),
                    CodNotaFiscal = table.Column<int>(type: "int", nullable: false),
                    QuantidadeServicos = table.Column<int>(type: "int", nullable: false),
                    ValorConsumo = table.Column<float>(type: "real", nullable: false),
                    Assinado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoLavanderias", x => x.CodConsumoLavanderia);
                });

            migrationBuilder.CreateTable(
                name: "ConsumoRestaurantes",
                columns: table => new
                {
                    CodConsumoRestaurante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(type: "int", nullable: false),
                    CodRestaurante = table.Column<int>(type: "int", nullable: false),
                    CodNotaFiscal = table.Column<int>(type: "int", nullable: false),
                    DescricaoConsumo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ValorConsumo = table.Column<float>(type: "real", nullable: false),
                    EntregaNoQuarto = table.Column<bool>(type: "bit", nullable: false),
                    Assinado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoRestaurantes", x => x.CodConsumoRestaurante);
                });

            migrationBuilder.CreateTable(
                name: "Frigobars",
                columns: table => new
                {
                    CodFrigobar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFrigobar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frigobars", x => x.CodFrigobar);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoFuncionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.CodFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Hoteis",
                columns: table => new
                {
                    CodHotel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeHotel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteis", x => x.CodHotel);
                });

            migrationBuilder.CreateTable(
                name: "Lavanderias",
                columns: table => new
                {
                    CodLavanderia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeServico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lavanderias", x => x.CodLavanderia);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    CodReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoReserva = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusReserva = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.CodReserva);
                });

            migrationBuilder.CreateTable(
                name: "Restaurantes",
                columns: table => new
                {
                    CodRestaurante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeRestaurante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurantes", x => x.CodRestaurante);
                });

            migrationBuilder.CreateTable(
                name: "ContatosClientes",
                columns: table => new
                {
                    CodContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(type: "int", nullable: false),
                    TelefoneContato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnderecoContato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClienteCodCliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatosClientes", x => x.CodContato);
                    table.ForeignKey(
                        name: "FK_ContatosClientes_Clientes_ClienteCodCliente",
                        column: x => x.ClienteCodCliente,
                        principalTable: "Clientes",
                        principalColumn: "CodCliente");
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    CodFilial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFilial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumQuartosLuxo = table.Column<int>(type: "int", nullable: false),
                    NumQuartosExecutivo = table.Column<int>(type: "int", nullable: false),
                    NumQuartosEconomico = table.Column<int>(type: "int", nullable: false),
                    EnderecoFilial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estrelas = table.Column<int>(type: "int", nullable: false),
                    HotelCodHotel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.CodFilial);
                    table.ForeignKey(
                        name: "FK_Filiais_Hoteis_HotelCodHotel",
                        column: x => x.HotelCodHotel,
                        principalTable: "Hoteis",
                        principalColumn: "CodHotel");
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    CodQuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adaptado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoQuarto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CapacidadeMaxima = table.Column<int>(type: "int", nullable: false),
                    CapacidadeOpcional = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<float>(type: "real", nullable: false),
                    CodFilial = table.Column<int>(type: "int", nullable: false),
                    FilialCodFilial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.CodQuarto);
                    table.ForeignKey(
                        name: "FK_Quartos_Filiais_FilialCodFilial",
                        column: x => x.FilialCodFilial,
                        principalTable: "Filiais",
                        principalColumn: "CodFilial");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContatosClientes_ClienteCodCliente",
                table: "ContatosClientes",
                column: "ClienteCodCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Filiais_HotelCodHotel",
                table: "Filiais",
                column: "HotelCodHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_FilialCodFilial",
                table: "Quartos",
                column: "FilialCodFilial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkins");

            migrationBuilder.DropTable(
                name: "CheckOuts");

            migrationBuilder.DropTable(
                name: "ConsumoFrigobars");

            migrationBuilder.DropTable(
                name: "ConsumoLavanderias");

            migrationBuilder.DropTable(
                name: "ConsumoRestaurantes");

            migrationBuilder.DropTable(
                name: "ContatosClientes");

            migrationBuilder.DropTable(
                name: "Frigobars");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Lavanderias");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Restaurantes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Hoteis");
        }
    }
}
