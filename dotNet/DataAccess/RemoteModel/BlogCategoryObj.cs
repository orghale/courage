using System.Collections.Generic;

namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegBlogCategoryObj : UserAuthObj
    {
        public string Name { get; set; }
        public int Status { get; set; }
    }

    public class EditBlogCategoryObj : UserAuthObj
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }


    //public class UpdateBlogCategoryFreqObj : UserAuthObj
    //{
    //    public int BlogCategoryId { get; set; }
       
    //}

    public class DeleteBlogCategoryObj : UserAuthObj
    {
        public int BlogCategoryId { get; set; }
    }

    //***************************** Response Objects  **********************************
    public class BlogCategorySearchObj : UserAuthObj
    {
        public List<BlogCategoryItemObj> BlogCategories { get; set; }
        public APIResponseStatus Status { get; set; }
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
    }
    
    public class BlogCategoryItemObj
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
        
    }

}