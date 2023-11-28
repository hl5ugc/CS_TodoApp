using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;


namespace TodoApp.WebApplication
{
    public partial class TodoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            const string url = "https://localhost:7174/api/Todos";
            using (var client = new HttpClient())
            {
                // 데이타 전송
                var json = JsonConvert.SerializeObject(new Todo { Title = "HttpClient", IsDone = true });
                var post = new StringContent(json, Encoding.UTF8, "application/json");
                //client.PostAsync(url, post).Wait();
                // 데이타 수신
                var response = client.GetAsync(url).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                var todos = JsonConvert.DeserializeObject<List<Todo>>(result);
                // 필터링 : LINQ로 함수형 프로그램 스타일 구현
                // Select:map()  select한 후 새로운 형태로 mapping 할 수 있다.
                //var q = todos.Select(t => t);
                //var q = from todo in todos
                //        select todo;
                //var q = todos.Select(t => new TodoViewModel
                //{
                //    Title = t.Title,
                //    IsDone = t.IsDone
                //});  

                //  
                var query = todos.AsQueryable<Todo>();      // query
                // 조건처리
                //if (DateTime.Now.Second % 2 == 0)
                //{
                //    query = query.Where(it => it.Id % 2 == 0);  // Even
                //}
                //else
                //{
                //    query = query.Where(it => it.Id % 2 == 1);  // Odd
                //}
                // 정렬
                const string sortOrder = "Title";
                query = (sortOrder == "Title" ? query.OrderBy(it => it.Title) : query).Where(it => it.IsDone == false);
                //query = query.Where(it =>  it.IsDone == false);

                var q = query.Select(t => new TodoViewModel
                {
                    Title = t.Title,
                    IsDone = t.IsDone
                });

                // 데이타 바인딩
                //this.GridView1.DataSource = todos;  //
                this.GridView1.DataSource = q;  //
                this.GridView1.DataBind();
                this.GridView2.DataSource =
                    todos
                    .Where(it => it.Id % 2 == 0 && it.IsDone == false)
                    .OrderByDescending(it => it.Title)
                    .Select(t => new { 제목 = t.Title, 완료여부 = t.IsDone })
                    .ToList();  //
                this.GridView2.DataBind();
            }
        }
    }

    public class TodoViewModel
    {
        public string Title { get; set; } = null;
        public bool IsDone { get; set; }
    }
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = null;
        public bool IsDone { get; set; }
    }
}