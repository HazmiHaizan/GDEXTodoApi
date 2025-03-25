﻿using Sieve.Attributes;

namespace GDEXTodoApi.Models
{
    public class TodoItem
    {
        [Sieve(CanFilter = true, CanSort = true)]
        public long Id { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string? Name { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Description { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime DueDate { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Status { get; set; }
    }
}
