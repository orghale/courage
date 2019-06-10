using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    //public class LottoSchoolCommentSearchObj : UserAuthObj
    //{
    //    public int LottoSchoolItemId { get; set; }
    //    public int PublishStatus { get; set; }

    //}

    //***************************** Response Objects  **********************************
    public class LottoSchoolCommentApprovalSearchObj : UserAuthObj
    {
        public List<LottoSchoolCommentApprovalItemObj> LottoSchoolCommentsApproval { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class LottoSchoolCommentApprovalItemObj
    {
        public int LottoSchoolItemId { get; set; }
        public string Comment { get; set; }
        public int PublishStatus { get; set; }
        public bool PublishStatusVal { get; set; }
        public string PublishStatusLabel { get; set; }
    }
}