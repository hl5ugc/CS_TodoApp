using Newtonsoft.Json;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();


        public TodoRepositoryJson(string filePath = @"C:\temp\Todos.json")
        {
            this._filePath = filePath;
            string todos = File.ReadAllText(filePath, Encoding.Default)   ; // json file Nuget 사용
            if (!String.IsNullOrEmpty(todos))
            {
                _todos = JsonConvert.DeserializeObject<List<Todo>>(todos);
            }
            //

        }

        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            //JSON 파일 저장
            string json =  JsonConvert.SerializeObject(_todos, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
        public void Detail()
        {
            foreach(var t in _todos)
            {
                Console.WriteLine($"{t.Id} : {t.Title}({t.IsDone})");
            }
            Console.WriteLine();
        }
    }
}
