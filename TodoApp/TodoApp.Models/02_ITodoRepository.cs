
using System;

namespace TodoApp.Models
{
    //
    public interface ITodoRepository
    {
        void Add(Todo model);   // 입력용 메서드 시그니처
        List<Todo> GetAll();    // 출력
        void Detail();
    }

}
