

// xxxxxx
using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace TodoApp.Apis.Tests.ConsoleApp
{

     class Program
    {
        static async void Main()
        {
            const string url = "https://localhost:7174/api/Todos";
            //  
            using (var client = new HttpClient())
            {
                // 데이타 전송
                var json = JsonConvert.SerializeObject(new Todo { Title = "HttpClient", IsDone = true });
                var post = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(url, post);
                // 데이타 수신
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                var todos = JsonConvert.DeserializeObject<List<Todo>>(result);

                foreach(var t in todos)
                {
                    Console.WriteLine($"{t.Id} : {t.Title}({t.IsDone})");
                }
            }
 
        }
    }
    public class Todo
    {
        // prop tab tab
        public int Id { get; set; }
        public string? Title { get; set; } = null;
        public bool IsDone { get; set; }
    }
}
