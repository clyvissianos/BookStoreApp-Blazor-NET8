using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.Blazor.Server.UI.Services.Base.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c2aa4d2-b8bd-4667-9c81-4433ce13d407", null, "Administrator", "ADMINISTRATOR" },
                    { "8d736b4d-ce19-42bd-8d0e-dbab3784501f", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "36511f73-13fe-4af9-a601-b67118479b1d", 0, "4c10277d-ad8e-457e-b0bd-a11462a747dd", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAELATKGbR27ypXmVyUWQZdcX/VBT6X+9ZqHapy9KYlgXH5egVVLS4VXZzz55bfml3RA==", null, false, "03fc0c57-defc-41a4-b4d8-d070ca035a97", false, "admin@bookstore.com" },
                    { "513455db-7f82-4e27-b5a4-352b407c2754", 0, "e4829dd9-40c3-43a1-a05c-81d64dcd2340", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAENEwb5Z62GGG6E8MkCMfUIoAh5EiVunnUjkoxuN+zlyIL42/bPrVvXCHcfI0VijDNQ==", null, false, "df3008f5-ebf6-4928-b6df-0ec0aa11157f", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6c2aa4d2-b8bd-4667-9c81-4433ce13d407", "36511f73-13fe-4af9-a601-b67118479b1d" },
                    { "8d736b4d-ce19-42bd-8d0e-dbab3784501f", "513455db-7f82-4e27-b5a4-352b407c2754" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c2aa4d2-b8bd-4667-9c81-4433ce13d407", "36511f73-13fe-4af9-a601-b67118479b1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d736b4d-ce19-42bd-8d0e-dbab3784501f", "513455db-7f82-4e27-b5a4-352b407c2754" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c2aa4d2-b8bd-4667-9c81-4433ce13d407");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d736b4d-ce19-42bd-8d0e-dbab3784501f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36511f73-13fe-4af9-a601-b67118479b1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "513455db-7f82-4e27-b5a4-352b407c2754");
        }
    }
}
