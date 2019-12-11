using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02_StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content{ get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; private set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = 0;
        }

        public void AddLike(){
            Likes++;
        }           
        
        public void RemoveLike()
        {
            Likes--;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}
