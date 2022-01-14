
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Lab5Zadanie.Models
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                if (context.TodoItems.Any())
                {
                    return;   
                }

                context.TodoItems.AddRange(
                    new TodoApi.Models.TodoItem
                    {
                        Id = 1,
                        date_of_borrowing_book = DateTime.Now,
                        title = "wiedzmin",
                        pages = 1000,
                        author = "Sapkowski"
                    },
                    new TodoApi.Models.TodoItem
                    {
                        Id = 2,
                        date_of_borrowing_book = DateTime.Now,
                        title = "Harry Potter",
                        pages = 1000,
                        author = "JK",
                    },
                    new TodoApi.Models.TodoItem
                    {
                        Id = 3,
                        date_of_borrowing_book = DateTime.Now,
                        title = "LEAGUEOOFLEGENDS",
                        pages = 1000,
                        author = "RIOT"
                    },
                    new TodoApi.Models.TodoItem
                    {
                        Id = 4,
                        date_of_borrowing_book = DateTime.Now,
                        title = "Czerwony Kapturek",
                        pages = 1000,
                        author = "Gal Anonim"
                    },
                    new TodoApi.Models.TodoItem
                    {
                        Id = 5,
                        date_of_borrowing_book = DateTime.Now,
                        title = "OTP RIVEN",
                        pages = 1000,
                        author = "KOFI"
                    }
                    );
                   

                context.SaveChanges();
            }
        }
    }
}