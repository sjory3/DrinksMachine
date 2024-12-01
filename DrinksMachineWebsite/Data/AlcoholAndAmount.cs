using Microsoft.AspNetCore.Mvc;

namespace DrinksMachineWebsite.Data
{
    public class AlcoholAndAmount
    {
        public Alcohol Alcohol { get; set; }
        public int amountOfShots { get; set; }

        public AlcoholAndAmount(Alcohol alcohol, int amountOfShots)
        {
            Alcohol = alcohol;
            this.amountOfShots = amountOfShots;
        }
    }
}
