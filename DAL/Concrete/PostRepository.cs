using DAL.Abstract;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL.Concrete
{
    public class PostRepository : IPostRepository
    {
        public void CreatePost(Post post)
        {
            string sql = "INSERT INTO Post (Author, Content) VALUES (@Author, @Content)";

            using (var connection = new SqlConnection(DataBaseOptions.DatabaseConnectionString))
            {
                connection.Execute(sql, new { Author = post.Author, Content = post.Content });
            }
            
        }

        public IList<Post> GetPosts()
        {
            List<Post> posts;
            string sql = "SELECT * FROM Post WHERE Created >= DATEADD(day, -1, GETDATE()) ORDER BY CREATED DESC";
            using (var connection = new SqlConnection(DataBaseOptions.DatabaseConnectionString))                 
            {
                posts = connection.Query<Post>(sql).ToList();
            }
            return posts;
        }
    }
} 
