using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Caching.Memory;

// REF: https://docs.microsoft.com/en-us/aspnet/web-api/overview/older-versions/creating-a-web-api-that-supports-crud-operations
// REF 2: https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/tutorials/first-web-api/samples/5.x/TodoApi

namespace ToDOAPi2.Controllers {
    [Route("api/items")]
    [ApiController]
    public class TodoController : ControllerBase {
        private List<TodoItem> _todoItems = new List<TodoItem>();
        private uint _nextId;


        public TodoController() {

            TodoItem todo1 = new TodoItem();
            todo1.Name = "Go Gym";
            todo1.IsCompleted = false;
            TodoItem todo2 = new TodoItem();
            todo2.Name = "Do Groceries";
            todo2.IsCompleted = false;
            this._todoItems.Add(todo1);
            todo2.ItemId = todo1.ItemId + 1;
            this._nextId = todo2.ItemId;
            this._todoItems.Add(todo2);
        }


        [HttpGet]
        public IEnumerable<TodoItem> GetAll() {
            return _todoItems;
        }

        [HttpGet("{id}")]
        public TodoItem GetItem(int id) {
            return TodoItemExists(id);
        }

        [HttpDelete("{id}")]
        public IEnumerable<TodoItem> DeleteItem(int id) {
            TodoItem item = TodoItemExists(id);
            this._todoItems.Remove(item);
            return _todoItems;

        }

        // POST: api/TodoItems
        [HttpPost]
        //public TodoItem PostTodoItem([FromBody] TodoItem item) {
        public IEnumerable<TodoItem> PostTodoItem(TodoItem item) {
            if (item == null) {
                throw new ArgumentNullException("item");
            }


            item.ItemId = this._nextId + 1;
            this._todoItems.Add(item);

            //return item;
            return _todoItems;

        }

        // PUT: api/TodoItems/1
        [HttpPut("{id}")]
        public TodoItem PutTodoItem(int id, TodoItem updatedItem) {
            TodoItemExists(id);
            updatedItem.ItemId = (uint)id;

            int index = _todoItems.FindIndex(i => i.ItemId == id);
            this._todoItems.RemoveAt(index);

            this._todoItems.Add(updatedItem);

            return this._todoItems[this._todoItems.Count - 1];


        }

        private TodoItem TodoItemExists(int id) {
            TodoItem item = this._todoItems.Find(p => p.ItemId == id);
            if (item == null) {
                throw new HttpException(HttpStatusCode.NotFound);
            }
            return item;
        }

    }
}


