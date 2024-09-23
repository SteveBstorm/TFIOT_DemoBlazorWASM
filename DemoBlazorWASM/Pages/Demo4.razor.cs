using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace DemoBlazorWASM.Pages
{
    public partial class Demo4
    {
        [Inject]
        public NavigationManager Nav { get; set; }

        public int Value { get; set; }

        public string ReponseDeCible { get; set; }

        public void SetReponse(string value) 
        { 
            ReponseDeCible = value;
        }
        public void Increment()
        {
            Value++;
        }
    }
}
