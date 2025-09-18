using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AplicationDbContextModelSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "empleados");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "departamentos");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_empleados",
                table: "empleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departamentos",
                table: "departamentos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_DepartamentoId",
                table: "empleados",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_empleados_departamentos_DepartamentoId",
                table: "empleados",
                column: "DepartamentoId",
                principalTable: "departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empleados_departamentos_DepartamentoId",
                table: "empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empleados",
                table: "empleados");

            migrationBuilder.DropIndex(
                name: "IX_empleados_DepartamentoId",
                table: "empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departamentos",
                table: "departamentos");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "empleados");

            migrationBuilder.RenameTable(
                name: "empleados",
                newName: "Empleado");

            migrationBuilder.RenameTable(
                name: "departamentos",
                newName: "Departamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "Id");
        }
    }
}
