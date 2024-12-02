using Share;

namespace Server.Service
{
	public class SinhVienService : ISinhVienService
	{
		private readonly HttpClient _httpClient;
		public SinhVienService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task Create(SinhVien sv)
		{
			await _httpClient.PostAsJsonAsync("api/SinhVien", sv);
		}

		public async Task Delete(int id)
		{
			await _httpClient.DeleteAsync($"api/SinhVien/{id}");
		}

		public async Task<List<SinhVien>> GetAll()
		{
			return await _httpClient.GetFromJsonAsync<List<SinhVien>>("api/SinhVien");
		}

		public async Task<SinhVien> GetById(int id)
		{
			return await _httpClient.GetFromJsonAsync<SinhVien>($"api/SinhVien/{id}");
		}

		public async Task Update(SinhVien sv)
		{
			await _httpClient.PutAsJsonAsync("api/SinhVien", sv);
		}
	}
}
