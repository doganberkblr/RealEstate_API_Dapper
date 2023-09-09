using System;
using RealEstate_API_Dapper.Dtos.CategoryDtos;
using RealEstate_API_Dapper.Models.DapperContext;
using Dapper;

namespace RealEstate_API_Dapper.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection=_context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}

