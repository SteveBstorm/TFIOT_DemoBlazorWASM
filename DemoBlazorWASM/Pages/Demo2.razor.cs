namespace DemoBlazorWASM.Pages
{
    public partial class Demo2
    {
        public List<Guid> Liste { get; set; }

        protected override void OnInitialized()
        {
            Liste = new List<Guid>();
            
            for(int i = 0; i < 50;  i++)
            {
                Liste.Add(Guid.NewGuid());
            }
        }
    }
}
