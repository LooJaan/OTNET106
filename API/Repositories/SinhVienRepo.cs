using API.Context;
using Microsoft.EntityFrameworkCore;
using Share;

namespace API.Repositories
{
	public class SinhVienRepo : ISinhVienRepo
	{
		private readonly AppDbContext _db;
		public SinhVienRepo(AppDbContext db)
		{
			_db = db;
		}
		public async Task Create(SinhVien sv)
		{
			_db.SinhViens.Add(sv);
			await _db.SaveChangesAsync();
		}

		public async  Task Delete(int id)
		{
			var svDele = await GetById(id);
			_db.SinhViens.Remove(svDele);
			await _db.SaveChangesAsync();
		}

		public async Task<List<SinhVien>> GetAll()
		{
			return await _db.SinhViens.ToListAsync();
		}

		public async Task<SinhVien> GetById(int id)
		{
			return await _db.SinhViens.FindAsync(id);
		}

		public async  Task Update(SinhVien sv)
		{
			_db.Entry(sv).State = EntityState.Modified;
			await _db.SaveChangesAsync();
		}
	}
}
