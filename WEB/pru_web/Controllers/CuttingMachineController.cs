using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

public class CuttingMachineController : Controller
{
    public static async Task<List<CuttingMachine>> GetMachinesAsync(string technology)
    {
        string baseUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut";
        string username = "lantekacademy";
        string password = ":cPIi<kyF(=5OXc";

        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(baseUrl);
        var byteArray = System.Text.Encoding.ASCII.GetBytes($"{username}:{password}");
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string apiUrl;
        switch (technology)
        {
            case "2":
                apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut/2";
                break;
            case "3":
                apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut/3";
                break;
            case "":
                apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut";
                break;
            default:
                apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut";
                break;
        }

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            List<CuttingMachine> machines = JsonConvert.DeserializeObject<List<CuttingMachine>>(jsonContent);
            return machines;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error en la solicitud: {ex.Message}");
            return null;
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetMachines(string technology)
    {
        var machines = await GetMachinesAsync(technology);
        return Json(machines);
    }
}

