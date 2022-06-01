using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        IComment _comment;

        public CommentManager(IComment comment)
        {
            _comment = comment;
        }
        public void AddComment(Comment comment)
        {
            _comment.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllComments(int id)
        {
            return _comment.GetAll(x => x.BlogId == id);
        }

        public Comment GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
