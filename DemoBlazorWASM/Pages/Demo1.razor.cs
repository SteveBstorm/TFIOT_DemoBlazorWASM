namespace DemoBlazorWASM.Pages
{
    public partial class Demo1
    {
        public int prop { get; set; } = 42;
        public bool isInactive { get; set; } = false;
        public void Increment()
        {
            prop++;
            if(prop > 45)  isInactive = true; 
        }

        public void Add(int value)
        {
            prop += value;
        }
    }
}
