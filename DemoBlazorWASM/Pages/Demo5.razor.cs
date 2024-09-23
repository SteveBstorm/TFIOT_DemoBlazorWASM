using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text.Json;

namespace DemoBlazorWASM.Pages
{
    public partial class Demo5
    {
        [Inject]
        public HttpClient Client { get; set; }

        protected override async Task OnInitializedAsync()
        {
            string url = "https://pokeapi.co/api/v2/pokemon";
            Client.BaseAddress = new Uri(url);

            PokeResult info = await Client.GetFromJsonAsync<PokeResult>(url);
            
        }
    }

    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokeResult
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }
}
