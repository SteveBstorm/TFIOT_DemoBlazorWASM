using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Pages
{
    public partial class Cible
    {
        [Parameter]
        public int id { get; set; }

        [Parameter]
        public string name { get; set; }

        [Parameter]
        public EventCallback<string> CoucouEvent { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            name = (id * 2).ToString();
            //Exemple à ne pas reproduire => Boucle infinie
            //if (id >= 10)
            //{
            //    await Console.Out.WriteLineAsync("test");
            //    await TestCallback();
            //}
        }

        public async Task TestCallback()
        {
           await CoucouEvent.InvokeAsync("test event");
        }
    }
}
