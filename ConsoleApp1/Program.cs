namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://localhost:5000/api/values");
            Console.WriteLine(response);
        }
    }
}