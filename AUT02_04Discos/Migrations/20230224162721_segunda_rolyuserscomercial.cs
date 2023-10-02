using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUT02_04Discos.Migrations
{
    public partial class segunda_rolyuserscomercial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ff18fb8-6653-4d0f-a90f-fde1803dfe19");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71eb5bee-0e20-4f6a-9c0c-28ea5bd769fc", "257fe082-1a46-481a-aa43-303ca1a042cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea505525-2540-46be-b05e-553449721468", "433e82a2-de09-47f6-95d6-968aca5f6901" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71eb5bee-0e20-4f6a-9c0c-28ea5bd769fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea505525-2540-46be-b05e-553449721468");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "257fe082-1a46-481a-aa43-303ca1a042cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "433e82a2-de09-47f6-95d6-968aca5f6901");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04b823ff-3ce8-4b72-8a21-7ff147b1402d", "52d323bb-ad88-48a0-be9e-c393780dd999", "Comercial", "COMERCIAL" },
                    { "0c2a090f-1cbc-4e33-9c01-471bd279a1d5", "6e1f2996-4171-41b6-9d35-67e54d262fca", "Admin", "ADMIN" },
                    { "2380203b-7c68-4eb4-b344-aabdf97cded6", "1990a0ec-9de2-4e78-a43e-9e00c961f076", "Manager", "MANAGER" },
                    { "ae79c3c6-f39b-4361-86b6-55dc867a0cce", "d4e13b53-55eb-4a67-aa34-7fbcec5c273b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "120c7dc2-3ce7-48bc-9324-2da1e77857cd", 0, "3d5b5815-c971-4aac-9650-0549bda11811", "comercial2@disquera.com", true, false, null, "COMERCIAL2@DISQUERA.COM", "COMERCIAL2@DISQUERA.COM", "AQAAAAEAACcQAAAAEAu700JOI2hr71H8JDplf9/J8NczzWiiIGXhfZ40bMreGZzvbXthq73raRwJ9/PQnw==", null, false, "d9ff1700-7d79-484d-af8f-53bc7cb7c375", false, "comercial2@disquera.com" },
                    { "50d450f5-9d07-49d4-9a1e-b3a08e1550ca", 0, "d07b365e-02b3-43c5-ac79-b9dcdcab8c52", "comercial1@disquera", true, false, null, "COMERCIAL1@DISQUERA.COM", "COMERCIAL1@DISQUERA.COM", "AQAAAAEAACcQAAAAEDsBJoYZc/G6i92HmKKaQXt8kc95M4HwX04ppB/DjcWGUptLC5MD9pwYGRZkqHUKJA==", null, false, "e4e345cc-f492-47d2-8320-07717859b362", false, "comercial1@disquera.com" },
                    { "61c47943-1c58-4f27-892f-21a968d77d03", 0, "a2a93081-23e3-41af-bd1f-07067e1af97e", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEISD1exkFaCRwvl9jNNop7kjPuej93ab4h94dWGYTYcHALzVbnjK6loAoeyp//Ohpw==", null, false, "9acb2a90-5cc9-4be7-9cca-72173d9b3e41", false, "admin@gmail.com" },
                    { "b37105ac-79ef-4b84-a258-e51eafa51aae", 0, "67da321b-8eac-460b-bf49-819d118b5a65", "manager@gmail.com", true, false, null, "MANAGER@GMAIL.COM", "MANAGER@GMAIL.COM", "AQAAAAEAACcQAAAAEG2WNW8q2+TgaMII44uk0cbeNHD4YpmSX6HEaL6P6MObRoE0Lyyu1HcpiwfE2inIDg==", null, false, "decd894c-0821-4725-ab6a-ace51a42157e", false, "manager@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "04b823ff-3ce8-4b72-8a21-7ff147b1402d", "120c7dc2-3ce7-48bc-9324-2da1e77857cd" },
                    { "04b823ff-3ce8-4b72-8a21-7ff147b1402d", "50d450f5-9d07-49d4-9a1e-b3a08e1550ca" },
                    { "0c2a090f-1cbc-4e33-9c01-471bd279a1d5", "61c47943-1c58-4f27-892f-21a968d77d03" },
                    { "2380203b-7c68-4eb4-b344-aabdf97cded6", "b37105ac-79ef-4b84-a258-e51eafa51aae" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae79c3c6-f39b-4361-86b6-55dc867a0cce");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04b823ff-3ce8-4b72-8a21-7ff147b1402d", "120c7dc2-3ce7-48bc-9324-2da1e77857cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04b823ff-3ce8-4b72-8a21-7ff147b1402d", "50d450f5-9d07-49d4-9a1e-b3a08e1550ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c2a090f-1cbc-4e33-9c01-471bd279a1d5", "61c47943-1c58-4f27-892f-21a968d77d03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2380203b-7c68-4eb4-b344-aabdf97cded6", "b37105ac-79ef-4b84-a258-e51eafa51aae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04b823ff-3ce8-4b72-8a21-7ff147b1402d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2a090f-1cbc-4e33-9c01-471bd279a1d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2380203b-7c68-4eb4-b344-aabdf97cded6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120c7dc2-3ce7-48bc-9324-2da1e77857cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50d450f5-9d07-49d4-9a1e-b3a08e1550ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61c47943-1c58-4f27-892f-21a968d77d03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b37105ac-79ef-4b84-a258-e51eafa51aae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71eb5bee-0e20-4f6a-9c0c-28ea5bd769fc", "b18dfb4c-1a8d-4e7e-b53f-a1d21ee6de1a", "Admin", "ADMIN" },
                    { "9ff18fb8-6653-4d0f-a90f-fde1803dfe19", "69b46926-66ef-4b16-8f7b-bf58be0c89b5", "User", "USER" },
                    { "ea505525-2540-46be-b05e-553449721468", "066abaa9-d71b-4905-a0c6-42559c777652", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "257fe082-1a46-481a-aa43-303ca1a042cf", 0, "293f86d2-f742-4275-985a-745246e2dcba", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAxO8b0gKO82EJN+LSG+2gjhtfOoDrbHhrEm4OqPV4fdrNJnS+Jdc22jrZUmhZFa0Q==", null, false, "30390d39-5f4a-4f44-9a67-c690442b83b5", false, "admin@gmail.com" },
                    { "433e82a2-de09-47f6-95d6-968aca5f6901", 0, "43b15414-a1a9-44c0-bfd7-d2dc38da32b3", "manager@gmail.com", true, false, null, "MANAGER@GMAIL.COM", "MANAGER@GMAIL.COM", "AQAAAAEAACcQAAAAENdPDB1k6qhW3n0oXOAHoYkZe3hVWUjJeRKYFTxiBpefZk1SoU1iebDaKXeikd5JTQ==", null, false, "73c571ac-7e37-481d-9cce-e9be9a7c813c", false, "manager@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "71eb5bee-0e20-4f6a-9c0c-28ea5bd769fc", "257fe082-1a46-481a-aa43-303ca1a042cf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea505525-2540-46be-b05e-553449721468", "433e82a2-de09-47f6-95d6-968aca5f6901" });
        }
    }
}
