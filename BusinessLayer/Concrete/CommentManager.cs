﻿using BusinessLayer.Abstract;
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
		ICommentDal _commentDal;

        public CommentManager(ICommentDal commentdal)
        {
			_commentDal = commentdal;
        }
        public void CommentAdd(Comment comment)
		{
			_commentDal.Insert(comment);
		}

		public void CommentDelete(Comment comment)
		{
			throw new NotImplementedException();
		}

		public void CommentUpdate(Comment comment)
		{
			throw new NotImplementedException();
		}

		public Comment GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{
			return _commentDal.GetListAll(x => x.CommentID == id);
		}

		
	}
}
