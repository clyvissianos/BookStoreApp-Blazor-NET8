using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace BookStoreApp.Blazor.Server.UI.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient client;
        private readonly ILocalStorageService localStorageService;

        public BaseHttpService(IClient client, ILocalStorageService localStorageService)
        {
            this.client = client;
            this.localStorageService = localStorageService;
        }

        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException apiException)
        {
            if (apiException.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation errors have occurred.", ValidationErrors = apiException.Response, Success = false };
            }
            if (apiException.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "The requested item could not be found.", Success = false };
            }
            if (apiException.StatusCode == 401)
            {
                return new Response<Guid>() { Message = "You are not authorized.", Success = false };
            }

            if(apiException.StatusCode >= 200 && apiException.StatusCode <= 299)
            {
                return new Response<Guid>() { Message = "Operation Reported Success.", Success = true };
            }

            return new Response<Guid>() { Message = "Something went wrong, please try again.", Success = false };
        }

        protected async Task GetBearerToken()
        {
            var token = await localStorageService.GetItemAsync<string>("accessToken");
            if (token != null)
            {
                client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            }
        }
    }
}
