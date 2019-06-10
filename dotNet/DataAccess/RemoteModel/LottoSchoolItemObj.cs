using System.Collections.Generic;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegLottoSchoolItemObj : UserAuthObj
    {
        public int LottoSchoolTopicId { get; set; }
        public int LottoSchoolCategoryId { get; set; }
        public string Title { get; set; }
        public string ItemContent { get; set; }
        public string Tags { get; set; }
        public string FeaturedImagePath { get; set; }
        public int Status { get; set; }
        public int PublishStatus { get; set; }
    }

    public class EditLottoSchoolItemObj : UserAuthObj
    {
        public int LottoSchoolItemId { get; set; }
        public int LottoSchoolTopicId { get; set; }
        public int LottoSchoolCategoryId { get; set; }
        public string Title { get; set; }
        public string ItemContent { get; set; }
        public string Tags { get; set; }
        public string FeaturedImagePath { get; set; }
        public int Status { get; set; }
        public int PublishStatus { get; set; }
    }

    public class DeleteLottoSchoolItemObj : UserAuthObj
    {
        public int LottoSchoolItemId { get; set; }

    }

    //***************************** Response Objects  **********************************
    public class LottoSchoolItemSearchObj : UserAuthObj
    {
        public List<LottoSchoolItemObj> LottoSchoolItems { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class LottoSchoolItemObj
    {
        public int LottoSchoolItemId { get; set; }
        public int LottoSchoolTopicId { get; set; }
        public string LottoSchoolTopicName { get; set; }
        public int LottoSchoolCategoryId { get; set; }
        public string LottoSchoolCategoryName { get; set; }
        public string Title { get; set; }
        public string ItemContent { get; set; }
        public string Tags { get; set; }
        public string FeaturedImagePath { get; set; }
       
        public int PublishStatus { get; set; }
        public bool PublishStatusVal { get; set; }
        public string PublishStatusLabel { get; set; }

        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<NameValueObject> AllLottoSchoolTopics { get; set; }
        public List<NameValueObject> LottoSchoolCategories { get; set; }
    }
}