using Microsoft.EntityFrameworkCore.Migrations;
using blazor_mysql2.Shared;
using Microsoft.EntityFrameworkCore;
using System;

namespace blazormysql2.Server.Migrations
{
     class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User
            {
                Title = "Sr",
                FirstName = "Luis",
                MiddleName = "Guilherme",
                LastName = "Sobral",
                DateOfBirth = Convert.ToDateTime("19990331"),
                Email = "sobrazinhoOchave@gmail.com",
                Password = "123456",
                ConfirmPassword = "123456",
                AcceptTerms = true
            }
    );
        }
        #endregion
    }
    public partial class login : Migration
    {
       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
