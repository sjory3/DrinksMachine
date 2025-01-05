using System.Net.NetworkInformation;
using Website.Models;
using Newtonsoft.Json;


namespace Website.Services
{
    public class DrinkService
    {
        // This method is a placeholder. Replace it with actual database logic.
        public Task SaveDrinkAsync(Drink drink)
        {
            Console.WriteLine("Saving drink to database...");

            string filepath = "data/Drinks.json";
            List<Drink> drinks = new List<Drink>();

            if (File.Exists(filepath))
            {
                Console.WriteLine("File found");
                string json = File.ReadAllText(filepath);
                drinks = JsonConvert.DeserializeObject<List<Drink>>(json);
                drinks.Add(drink);
                // Write the updated data back to the JSON file
                string updatedJson = JsonConvert.SerializeObject(drinks, Formatting.Indented);
                File.WriteAllText(filepath, updatedJson);
                Console.WriteLine("Data appended successfully.");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            // Implement your database save logic here
            return Task.CompletedTask;
        }
    }
}
