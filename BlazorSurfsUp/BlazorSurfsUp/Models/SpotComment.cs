using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSurfsUp.Models
{
    public class SpotComment
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Poster { get; set; }
        public SpotComment(string title, string body)
        {
            Title = title;
            Body = body;
        }
    }
}
