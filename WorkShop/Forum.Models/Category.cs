using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Category
    {
        public Category(int id, string name, IEnumerable<int> postIds)
        {
            this.Id = id;
            this.Name = name;
            this.Posts = new List<int>(postIds);
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<int> Posts { get; set; }


    }
}
