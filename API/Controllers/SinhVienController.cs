using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Share;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SinhVienController : ControllerBase
	{
		private readonly ISinhVienRepo _repository;
		public SinhVienController(ISinhVienRepo repository)
		{
			_repository = repository;
		}
		[HttpGet]
		public async Task<List<SinhVien>> GetAll()
		{
			return await _repository.GetAll();
		}
		[HttpGet("{id}")]
		public async Task<SinhVien> GetById(int id)
		{
			return await _repository.GetById(id);
		}
		[HttpPost]
		public async Task Create(SinhVien sv)
		{
			await _repository.Create(sv);
		}
		[HttpPut]
		public async Task Update(SinhVien sv)
		{
			await _repository.Update(sv);
		}
		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			await _repository.Delete(id);
		}
	}
}
