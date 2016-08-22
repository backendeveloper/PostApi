using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contract.Dtos
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        //TODO: Parent ne?
        public SelectOptionDto Parent { get; set; }
        public string Description { get; set; }

        //TODO: Count ne?
        public int Count { get; set; }
        public bool IsChecked { get; set; }
    }
}
