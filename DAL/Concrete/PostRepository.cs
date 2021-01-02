using DAL.Abstract;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete
{
    public class PostRepository : IPostRepository
    {
        public void CreatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public IList<Post> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}
