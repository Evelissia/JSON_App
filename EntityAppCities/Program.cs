using System;
using System.IO;
using System.Text;
namespace EntityAppCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "json1.json");
            var json = File.ReadAllText(path);

            var jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<City>>(json);
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Cities.AddRange(jsonObject);
                db.SaveChanges();

            }
        }
    }
}