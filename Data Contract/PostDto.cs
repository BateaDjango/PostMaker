using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Contract
{
    public class PostDto
    {
        //Send data between Aplication layeer and bll

        public int Id { get; set; }
        
        public string Author { get; set; }
        
        public string Content { get; set; }
        
        public DateTime Created { get; set; }

    }
}
