namespace DrinksMachineWebsite.Data
{
    public class Alcohol
    {
        public string name {  get; set; }
        public float Alcoholpercent { get; set; }
        public float Amount { get; set; }

        public Alcohol(string name, float alcoholpercent, float amount)
        {
            this.name = name;
            Alcoholpercent = alcoholpercent;
            Amount = amount;
        }
    }
}
