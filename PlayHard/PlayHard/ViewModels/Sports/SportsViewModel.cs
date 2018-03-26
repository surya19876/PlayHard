using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace PlayHard.ViewModels.Sports
{
    public class SportsViewModel
    {
        public ObservableCollection<Models.Sports.Sports> Sports { get; set; }

        public SportsViewModel()
        {
            GetAllAvailableSports();
        }
        private async void GetAllAvailableSports()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var x = client.GetAsync("https://playhard.azurewebsites.net/api/Sports").Result;
            if (x.IsSuccessStatusCode)
            {
                var content = await x.Content.ReadAsStringAsync();
                Sports = JsonConvert.DeserializeObject<ObservableCollection<Models.Sports.Sports>>(content);
            }
        }
    }


}
