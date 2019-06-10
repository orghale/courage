using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegBlogCommentObj : UserAuthObj
    {
        public int BlogPostId { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }

    }

    public class ApproveBlogCommentObj : UserAuthObj
    {
        public int BlogCommentId { get; set; }
        public int Status { get; set; }
    }

    public class DeleteBlogCommentObj : UserAuthObj
    {
        public int BlogCommentId { get; set; }

    }
    //***************************** Response Objects  **********************************
    public class BlogCommentItemObj : UserAuthObj
    {
        public int BlogPostId { get; set; }
        public int PublishStatus { get; set; }

    }

    public class BlogCommentSearchObj : UserAuthObj
    {
        public List<BlogCommentItemObj> BlogComments { get; set; }
        //public APIResponseStatus Status { get; set; }
    }



}