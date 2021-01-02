using BLL.Abstract;
using Data_Contract;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concrete
{
    public class PostService : IPostService
    {
        public void CreatePost(PostDto dto)
        {
            var post = new Post()
            {
                Author = dto.Author,
                Content = dto.Content.Replace("\n", "<br />"),
                Created = dto.Created,
                Id = dto.Id
            };
        }

        public IList<PostDto> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}
