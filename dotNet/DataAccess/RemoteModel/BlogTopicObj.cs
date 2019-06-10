using System.Collections.Generic;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegBlogTopicObj : UserAuthObj
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

    }

    public class EditBlogTopicObj : UserAuthObj
    {
        public int BlogTopicId { get; set; }
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
    }

    //public class UpdateBlogTopicFreqObj : UserAuthObj
    //{
    //    public int BlogTopicId { get; set; }
        
    //}

    public class DeleteBlogTopicObj : UserAuthObj
    {
        public int BlogTopicId { get; set; }
    }
    //***************************** Response Objects  **********************************
    public class BlogTopicSearchObj : UserAuthObj
    {
        public List<BlogTopicItemObj> BlogTopics { get; set; }
        public APIResponseStatus Status { get; set; }
    }

    public class BlogTopicItemObj
    {
        public int BlogTopicId { get; set; }
        public string Name { get; set; }
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<NameValueObject> AllBlogCategories { get; set; }

    }

}