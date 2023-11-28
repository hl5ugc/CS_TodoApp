﻿using System;
// // CRUD: 컬렉션, 파일, 데이터베이스 등의 저장소에 데이터를 저장, 조회, 수정, 삭제하는 작업
namespace TodoApp.Models
{
    /// <summary>
    /// 모델 클래스
    /// </summary>
    public class Todo
    {
        // prop tab tab
        public int Id { get; set; }
        public string Title { get; set; } = null! ;
        public bool IsDone { get; set; }
    }
 
}
