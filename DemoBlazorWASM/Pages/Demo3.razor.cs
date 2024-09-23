using DemoBlazorWASM.Models;
using System.Text.Json;

namespace DemoBlazorWASM.Pages
{
    public partial class Demo3
    {


        public Student FormModel { get; set; }
        public Demo3()
        {
            FormModel = new Student();
        }

        public void OnSubmit()
        {
            Console.WriteLine(JsonSerializer.Serialize(FormModel));
        }
    }
}
