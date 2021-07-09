using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ConsumeAPIUsingHttpClient
{
    public class Foods
    {
        public List<Food> data { get; set; }
    }
    public class Food
    {

        public string city { get; set; }
        public string name { get; set; }
        public decimal? estimated_cost { get; set; }
        public UserRating user_rating { get; set; }
        public long id { get; set; }
    }

    public class UserRating
    {
        public double? average_rating { get; set; }
        public long? votes { get; set; }
    }
    class Result
    {

        /*
         * Complete the 'getTopRatedFoodOutlets' function below.
         *
         * URL for cut and paste
         * https://jsonmock.hackerrank.com/api/food_outlets?city=<city>&page=<pageNumber>
         *
         * The function is expected to return an array of strings.
         * 
         * The function accepts only city argument (String).
         */
        public static async Task<List<string>> getFoodOutletsAsync(string city)
        {
            Foods responseObj = new Foods();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonmock.hackerrank.com/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();
            response = await client.GetAsync("api/food_outlets?city=" + city).ConfigureAwait(false);
            string result = String.Empty;
            List<string> ls = new List<string>();
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                responseObj = JsonConvert.DeserializeObject<Foods>(result);
            }
            var maxRating = responseObj.data.Max(x => x.user_rating.average_rating);
            ls = responseObj.data.Where(x => x.user_rating.average_rating == maxRating).Select(x => x.name + ", " + x.user_rating.average_rating).ToList();
            return ls;
        }

        public static List<string> getTopRatedFoodOutlets(string city)
        {
            List<string> ls = getFoodOutletsAsync(city).GetAwaiter().GetResult();
            return ls;
        }

    }
    //input: Denver
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().Trim();
            List<string> result = Result.getTopRatedFoodOutlets(city);
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
