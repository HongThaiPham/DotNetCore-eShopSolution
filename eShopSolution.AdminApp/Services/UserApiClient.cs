using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.ViewModels.System.Users;
using Newtonsoft.Json;

namespace eShopSolution.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public UserApiClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient("eShop");
            var respone = await client.PostAsync("/api/user/authenticate", httpContent);
            var token = await respone.Content.ReadAsStringAsync();
            return token;
        }
    }
}
