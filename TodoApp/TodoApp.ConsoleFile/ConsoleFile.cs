using TodoApp.Models;

namespace TodoApp.ConsoleFile
{
    internal class ConsoleFile
    {
        static void Main(string[] args)
        {
  
            ITodoRepository _repository = new TodoRepositoryFile(@"C:\Temp\Todos.txt");
            List<Todo> _todoList = new List<Todo>();
            // [1] 기본 데이타 출력
            _todoList = _repository.GetAll();
            foreach (var t in _todoList)
            {
                Console.WriteLine($"{t.Id} - {t.Title}({t.IsDone})");
            }
            Console.WriteLine();
            // [2] 데이타 입력
            Todo _todo = new Todo { Title = "Database 학습", IsDone = false } ;
            _repository.Add(_todo);
            // [3] 변경 데이타 출력
            _todoList = _repository.GetAll(); // 다시 로드
            _repository.Detail();
        }
    }
}
