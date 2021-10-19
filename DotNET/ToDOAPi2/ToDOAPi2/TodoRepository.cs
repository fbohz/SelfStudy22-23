using System;
using System.Collections.Generic;

//namespace ToDOAPi2.Models {
//    public class TodoRepository : ITodoItemRepository {
//        private int _nextId = 1;
//        private List<TodoItem> _todoItems = new List<TodoItem>();

//        public TodoRepository() {
//            Add(new TodoItem { Name = "Go Gym", IsCompleted = false });
//        }

//        public IEnumerable<TodoItem> GetAll() {
//            return _todoItems;
//        }

    //    public Product Get(int id) {
    //        return products.Find(p => p.Id == id);
    //    }

    //    public Product Add(Product item) {
    //        if (item == null) {
    //            throw new ArgumentNullException("item");
    //        }
    //        item.Id = _nextId++;
    //        products.Add(item);
    //        return item;
    //    }

    //    public void Remove(int id) {
    //        products.RemoveAll(p => p.Id == id);
    //    }

    //    public bool Update(Product item) {
    //        if (item == null) {
    //            throw new ArgumentNullException("item");
    //        }
    //        int index = products.FindIndex(p => p.Id == item.Id);
    //        if (index == -1) {
    //            return false;
    //        }
    //        products.RemoveAt(index);
    //        products.Add(item);
    //        return true;
    //    }
    //}
//}
