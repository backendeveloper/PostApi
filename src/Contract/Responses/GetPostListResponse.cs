using System;
using System.Collections.Generic;
using Contract.Dtos;

namespace Contract.Responses
{
    public class GetPostListResponse : BaseResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string DateCreated { get; set; }
        public string Slug { get; set; }
        public string RelativeLink { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public List<TagDto> Tags { get; set; }
        public string[] Comments { get; set; }
        public bool IsPublished { get; set; }
        public bool IsChecked { get; set; }
    }
}
