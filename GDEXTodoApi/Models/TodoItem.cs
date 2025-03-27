using Sieve.Attributes;
using System.ComponentModel;

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

        [DefaultValue("22/3/2025")]
        [Sieve(CanFilter = true, CanSort = true)]
        public string DueDate { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Status { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Category { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Priority { get; set; }
    }
}
