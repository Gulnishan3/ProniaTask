using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using WebApplication4.Constants;
using WebApplication4.Models;
using WebApplication4.Repositories.Abstractions;

namespace WebApplication4.Repositories.Implementation
{
    public class SlideRepository : ISliderRepository
    {
        private IDbConnection _connection { get => new SqlConnection(ConnectionStrings.SqlConnectionString); }
        public async Task AddAsync(Slider entity)
        {
            using var db = _connection;
            await db.ExecuteAsync("INSERT INTO Sliders VALUES (@Title, @Description, @Price, @ImagePath)", entity);
        }
        public async Task DeleteAsync(int id)
        {
            using var db = _connection;
            await db.ExecuteAsync("DELETE FROM Sliders WHERE Id = @Id", new { Id = id });
        }

        public Task DeleteAsync(Slider entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            using var db = _connection ;
            var list=await db.QueryAsync<Slider>("SELECT * FROM Sliders");
            return list.ToList();
        }

        public Task<Slider> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Slider entity)
        {
            using var db = _connection;
            var service = db.ExecuteAsync("UPDATE Sliders SET Name = @Name, Description = @Description, Price = @ Price, ImagePath = @ImagePath WHERE Id = @Id", entity);
            return service;
        }
    }
}
