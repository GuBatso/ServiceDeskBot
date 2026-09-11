using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceDeskBot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaFluentApiENavegacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InteracoesChatbot",
                table: "InteracoesChatbot");

            migrationBuilder.RenameTable(
                name: "InteracoesChatbot",
                newName: "InteracoesChatBot");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuarios",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Usuarios",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "SenhaHash",
                table: "Tecnicos",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tecnicos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tecnicos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "SubCategorias",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Setores",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Locais",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Locais",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "MensagemEnviada",
                table: "InteracoesChatBot",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "InteracoesChatBot",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CampoAlterado",
                table: "HistoricosChamados",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "AlteradoPorId",
                table: "HistoricosChamados",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TecnicoId",
                table: "HistoricosChamados",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Patrimonio",
                table: "Equipamentos",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Equipamentos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Equipamentos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "Critico",
                table: "Equipamentos",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Chamados",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Prioridade",
                table: "Chamados",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroChamado",
                table: "Chamados",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Impacto",
                table: "Chamados",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categorias",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteracoesChatBot",
                table: "InteracoesChatBot",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Telefone",
                table: "Usuarios",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tecnicos_Email",
                table: "Tecnicos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Setores_LocalId",
                table: "Setores",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_InteracoesChatBot_ChamadoId",
                table: "InteracoesChatBot",
                column: "ChamadoId");

            migrationBuilder.CreateIndex(
                name: "IX_InteracoesChatBot_UsuarioId",
                table: "InteracoesChatBot",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosChamados_ChamadoId",
                table: "HistoricosChamados",
                column: "ChamadoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosChamados_TecnicoId",
                table: "HistoricosChamados",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_LocalId",
                table: "Equipamentos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_SetorId",
                table: "Equipamentos",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_CategoriaId",
                table: "Chamados",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_EquipamentoId",
                table: "Chamados",
                column: "EquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_LocalId",
                table: "Chamados",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_NumeroChamado",
                table: "Chamados",
                column: "NumeroChamado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_SubCategoriaId",
                table: "Chamados",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_TecnicoId",
                table: "Chamados",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_UsuarioId",
                table: "Chamados",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Categorias_CategoriaId",
                table: "Chamados",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Equipamentos_EquipamentoId",
                table: "Chamados",
                column: "EquipamentoId",
                principalTable: "Equipamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Locais_LocalId",
                table: "Chamados",
                column: "LocalId",
                principalTable: "Locais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_SubCategorias_SubCategoriaId",
                table: "Chamados",
                column: "SubCategoriaId",
                principalTable: "SubCategorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Tecnicos_TecnicoId",
                table: "Chamados",
                column: "TecnicoId",
                principalTable: "Tecnicos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Usuarios_UsuarioId",
                table: "Chamados",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Locais_LocalId",
                table: "Equipamentos",
                column: "LocalId",
                principalTable: "Locais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Setores_SetorId",
                table: "Equipamentos",
                column: "SetorId",
                principalTable: "Setores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosChamados_Chamados_ChamadoId",
                table: "HistoricosChamados",
                column: "ChamadoId",
                principalTable: "Chamados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosChamados_Tecnicos_TecnicoId",
                table: "HistoricosChamados",
                column: "TecnicoId",
                principalTable: "Tecnicos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InteracoesChatBot_Chamados_ChamadoId",
                table: "InteracoesChatBot",
                column: "ChamadoId",
                principalTable: "Chamados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InteracoesChatBot_Usuarios_UsuarioId",
                table: "InteracoesChatBot",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Setores_Locais_LocalId",
                table: "Setores",
                column: "LocalId",
                principalTable: "Locais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Categorias_CategoriaId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Equipamentos_EquipamentoId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Locais_LocalId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_SubCategorias_SubCategoriaId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Tecnicos_TecnicoId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Usuarios_UsuarioId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Locais_LocalId",
                table: "Equipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Setores_SetorId",
                table: "Equipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosChamados_Chamados_ChamadoId",
                table: "HistoricosChamados");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosChamados_Tecnicos_TecnicoId",
                table: "HistoricosChamados");

            migrationBuilder.DropForeignKey(
                name: "FK_InteracoesChatBot_Chamados_ChamadoId",
                table: "InteracoesChatBot");

            migrationBuilder.DropForeignKey(
                name: "FK_InteracoesChatBot_Usuarios_UsuarioId",
                table: "InteracoesChatBot");

            migrationBuilder.DropForeignKey(
                name: "FK_Setores_Locais_LocalId",
                table: "Setores");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Telefone",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Tecnicos_Email",
                table: "Tecnicos");

            migrationBuilder.DropIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_Setores_LocalId",
                table: "Setores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InteracoesChatBot",
                table: "InteracoesChatBot");

            migrationBuilder.DropIndex(
                name: "IX_InteracoesChatBot_ChamadoId",
                table: "InteracoesChatBot");

            migrationBuilder.DropIndex(
                name: "IX_InteracoesChatBot_UsuarioId",
                table: "InteracoesChatBot");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosChamados_ChamadoId",
                table: "HistoricosChamados");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosChamados_TecnicoId",
                table: "HistoricosChamados");

            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_LocalId",
                table: "Equipamentos");

            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_SetorId",
                table: "Equipamentos");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_CategoriaId",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_EquipamentoId",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_LocalId",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_NumeroChamado",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_SubCategoriaId",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_TecnicoId",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_UsuarioId",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TecnicoId",
                table: "HistoricosChamados");

            migrationBuilder.RenameTable(
                name: "InteracoesChatBot",
                newName: "InteracoesChatbot");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SenhaHash",
                table: "Tecnicos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tecnicos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tecnicos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "SubCategorias",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Setores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Locais",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Locais",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "MensagemEnviada",
                table: "InteracoesChatbot",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "InteracoesChatbot",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CampoAlterado",
                table: "HistoricosChamados",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "AlteradoPorId",
                table: "HistoricosChamados",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Patrimonio",
                table: "Equipamentos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Equipamentos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Equipamentos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "Critico",
                table: "Equipamentos",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Chamados",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Prioridade",
                table: "Chamados",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroChamado",
                table: "Chamados",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Impacto",
                table: "Chamados",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categorias",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteracoesChatbot",
                table: "InteracoesChatbot",
                column: "Id");
        }
    }
}
