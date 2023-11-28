// See https://aka.ms/new-console-template for more information
using TodoApp.Models;


    ITodoRepository _repository = new TodoRepositoryInMemory();
    List<Todo> todos = new List<Todo>();
    todos = _repository.GetAll();
    // [1] 기본 데이터 출력
    foreach (var t in todos)
    {
        Console.WriteLine($"{t.Id} - {t.Title}({t.IsDone})");
    }
    // [2] 데이타 입력
    Todo todo = new Todo { Title = "Database", IsDone = true };
    _repository.Add(todo);
    todos = _repository.GetAll();

    foreach (var t in todos)
    {
        Console.WriteLine($"{t.Id} - {t.Title}({t.IsDone})");
    }

