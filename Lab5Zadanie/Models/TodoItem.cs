using System;
using System.ComponentModel.DataAnnotations;

namespace Lab5Zadanie.Models
{

    namespace TodoApi.Models
    {
        public class TodoItem
        {
            [Key]
            public long Id { get; set; }
            public DateTime date_of_borrowing_book { get; set; }
            public string title { get; set; }
            public int pages { get; set; }
            public string author { get; set; }
        }
    }
}