namespace DrinksMachineWebsite.Data
{
    public class Drinks
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public AlcoholAndAmount AlcoholAndAmounts { get; set; }

        public Drinks(string name, string description, AlcoholAndAmount alcoholAndAmounts)
        {
            Name = name;
            Description = description;
            AlcoholAndAmounts = alcoholAndAmounts;
        }

    }
}
