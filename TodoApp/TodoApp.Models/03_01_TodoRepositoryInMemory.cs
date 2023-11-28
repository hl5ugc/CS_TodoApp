using System;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        // Database in Memroy
        private static List<Todo> _todoList = new List<Todo>();
        //ctor
        public TodoRepositoryInMemory()
        {   // 생성자 초기화
            _todoList =  new List<Todo> 
            { 
                new Todo{Id=1,Title="ASP.Net 학습",IsDone = false },
                new Todo{Id=2,Title="Blazor 학습",IsDone = false },
                new Todo{Id=3,Title="C# 학습",IsDone = false }
            };
        }
        // In memory database 사용 영역
        public void Add(Todo model)
        {
            model.Id = _todoList.Max(x => x.Id) + 1;
            _todoList.Add(model);
        }
        public List<Todo> GetAll()
        {
            return _todoList.ToList(); // ToList()생략 가능
        }
        public void Detail()
        {
            foreach (var t in _todoList)
            {
                Console.WriteLine($"{t.Id} : {t.Title}({t.IsDone})");
            }
            Console.WriteLine();
        }
    }

}
