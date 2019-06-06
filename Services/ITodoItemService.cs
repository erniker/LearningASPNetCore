using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASPDotNetCoreTodo.Models;
using ASPDotNetCoreTodo.Services;

namespace ASPDotNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}