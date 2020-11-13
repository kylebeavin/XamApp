using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WishListPage : ContentPage
    {
        public WishListPage()
        {
            InitializeComponent();
        }

        private async Task<HttpResponseMessage> GetWeatherJson()
        {
            try
            {

            using (var client = new HttpClient())
            {
                    //client.BaseAddress = new Uri("http://localhost:50975");
                    client.BaseAddress = new Uri("https://kbeavinapi.azurewebsites.net/");
                    client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("api/test/");

                    if (response.IsSuccessStatusCode)
                    {
                        ViewModels.ItemsViewModel Items;
                        string content = await response.Content.ReadAsStringAsync();
                        //Items = JsonConvert.DeserializeObject<List<ViewModels.ItemsViewModel>>(content);
                    }
                    return response;
            }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage();
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await GetWeatherJson();
        }
    }
}