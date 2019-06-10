using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegProductCategoryObj : UserAuthObj
    {
        public string Name { get; set; }
        public int Status { get; set; }

    }

    public class EditProductCategoryObj : UserAuthObj
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

    }

    public class DeleteProductCategoryObj : UserAuthObj
    {
        public int ProductCategoryId { get; set; }
       
    }

    //***************************** Response Objects  **********************************
    public class ProductCategoryRespObj
    {
        public List<ProductCategoryItemObj> ProductCategories { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class ProductCategoryItemObj
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
    }

}