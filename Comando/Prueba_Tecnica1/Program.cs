using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Prueba_Tecnica
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string baseUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut";
            string username = "lantekacademy"; // Reemplaza con tu nombre de usuario
            string password = ":cPIi<kyF(=5OXc"; // Reemplaza con tu contraseña

            // Crear y configurar HttpClient con autenticación básica
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseUrl);
            var byteArray = System.Text.Encoding.ASCII.GetBytes($"{username}:{password}");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            bool outloop = false;
            while (outloop == false)
            {

                Console.WriteLine("Seleccione la tecnología:");
                Console.WriteLine("1. 2D");
                Console.WriteLine("2. 3D");
                Console.WriteLine("3. Todos");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                string apiUrl;
                string technology;
                switch (choice)
                {
                    case "1":
                        apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut/2";
                        technology = "2D";
                        break;
                    case "2":
                        apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut/3";
                        technology = "3D";
                        break;
                    case "3":
                        apiUrl = "https://app-academy-neu-codechallenge.azurewebsites.net/api/cut";
                        technology = "";
                        break;
                    case "4":
                        outloop = true;
                        Console.WriteLine("Gracias por consultar las maquinas.");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Se a producido un error");
                        return;
                }

                try
                {
                    // Realizar una solicitud GET a la API
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode(); // Lanzar una excepción si la solicitud falla

                    // Deserializar la respuesta JSON a una lista de máquinas de corte
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<CuttingMachine> machines = JsonConvert.DeserializeObject<List<CuttingMachine>>(jsonContent);

                    // Mostrar la lista de máquinas de corte
                    Console.WriteLine($"Máquinas de corte disponibles ({technology}):");
                    foreach (var machine in machines)
                    {
                        Console.WriteLine($"Name: {machine.Name}");
                        Console.WriteLine($"Manufacturer: {machine.Manufacturer}");
                        Console.WriteLine($"Cutting Technology: {technology}");
                        Console.WriteLine();
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error en la solicitud: {ex.Message}");
                }
            }
        }

        
    }

    public class CuttingMachine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }
}
