using System.Collections.Generic;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegBlogPostObj : UserAuthObj
    {
        public int BlogCategoryId { get; set; }
        public int BlogTopicId { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string Tags { get; set; }
        public string FeaturedImagePath { get; set; }
        //public bool IsPublished { get; set; }
        //public int Status { get; set; }

    }

    public class EditBlogPostObj : UserAuthObj
    {
        public int BlogPostId { get; set; }
        public int BlogCategoryId { get; set; }
        public int BlogTopicId { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string Tags { get; set; }
        public string FeaturedImagePath { get; set; }
        //public bool IsPublished { get; set; }
        //public int Status { get; set; }
    }

    public class DeleteBlogPostObj : UserAuthObj
    {
        public int BlogPostId { get; set; }

    }
    //***************************** Response Objects  **********************************
    public class BlogPostSearchObj : UserAuthObj
    {
        public List<BlogPostItemObj> BlogPosts { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class BlogPostItemObj
    {
        public int BlogPostId { get; set; }
        public bool IsPublished { get; set; }
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public int BlogTopicId { get; set; }
        public string BlogTopicName { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string Tags { get; set; }
        public string FeaturedImagePath { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<NameValueObject> AllBlogCategories { get; set; }
        public List<NameValueObject> AllBlogTopics { get; set; }
    }
}