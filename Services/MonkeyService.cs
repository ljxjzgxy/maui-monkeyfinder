using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient _httpClient;

    public MonkeyService()
    {
        _httpClient = new HttpClient();
    }
    List<Monkey> monkeyList = new List<Monkey>();
    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeyList.Count > 0)
            return monkeyList;

        var url = "https://montemagno.com/monkeys.json";
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        return monkeyList;
    }
}
