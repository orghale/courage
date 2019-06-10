using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegLottoSchoolCategoryObj : UserAuthObj
    {
        public string Name { get; set; }
        public int Status { get; set; }

    }

    public class EditLottoSchoolCategoryObj : UserAuthObj
    {
        public int LottoSchoolCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

    }

    public class DeleteLottoSchoolCategoryObj : UserAuthObj
    {
        public int LottoSchoolCategoryId { get; set; }
        
    }
    
    //***************************** Response Objects  **********************************
    public class LottoSchoolCategorySearchObj : UserAuthObj
    {
        public List<LottoSchoolCategoryItemObj> LottoSchoolCategories { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class LottoSchoolCategoryItemObj
    {
        public int LottoSchoolCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
    }

}