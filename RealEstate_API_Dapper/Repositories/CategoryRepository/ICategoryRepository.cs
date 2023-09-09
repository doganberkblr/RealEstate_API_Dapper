using System;
using RealEstate_API_Dapper.Dtos.CategoryDtos;

namespace RealEstate_API_Dapper.Repositories.CategoryRepository
{
	public interface ICategoryRepository
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		void CreateCategory(CreateCategoryDto categoryDto);
	}
}

