using System.Collections.Generic;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegLottoSchoolTopicObj : UserAuthObj
    {
        public int LottoSchoolCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }

    public class EditLottoSchoolTopicObj : UserAuthObj
    {
        public int LottoSchoolTopicId { get; set; }
        public int LottoSchoolCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }

    public class DeleteLottoSchoolTopicObj : UserAuthObj
    {
        public int LottoSchoolTopicId { get; set; }

    }

    //***************************** Response Objects  **********************************
    public class LottoSchoolTopicSearchObj : UserAuthObj
    {
        public List<LottoSchoolTopicItemObj> LottoSchoolTopics { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class LottoSchoolTopicItemObj
    {
        public int LottoSchoolTopicId { get; set; }
        public int LottoSchoolCategoryId { get; set; }
        public string LottoSchoolCategoryName { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<NameValueObject> AllLottoSchoolTopics { get; set; }
    }
}