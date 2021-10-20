using System;
using System.ComponentModel.DataAnnotations;

namespace ToDOAPi2 {

    public class TodoItem {
        public uint ItemId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsCompleted { get; set; }


        // ERROR: System.NotSupportedException: 'Deserialization of reference types without parameterless constructor is not supported.

        //public TodoItem(string name, bool isCompleted) {
        //    Name = name;
        //    IsCompleted = isCompleted;
        //}
    }
}
