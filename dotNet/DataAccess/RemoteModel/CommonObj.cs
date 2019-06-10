

namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class UserAuthObj
    {
        public string SysPathCode { get; set; }
        public int AdminUserId { get; set; }
        public string LoginIP { get; set; }
    }

    public class SettingSearchObj : UserAuthObj
    {
        public int SettingId { get; set; }
        public int Status { get; set; }
        public bool IsPublished { get; set; }
    }

    public class SettingRegRespObj 
    {
        public int SettingId { get; set; }
        public APIResponseStatus Status { get; set; }
        public APIResponseStatus IsPublished { get; set; }
    }

    public class APIResponseStatus
    {
        public bool IsSuccessful { get; set; }
        public string CustomToken { get; set; }
        public string CustomSetting { get; set; }
        public APIResponseMessage Message { get; set; }
    }

    public class APIResponseMessage
    {
        public string FriendlyMessage { get; set; }
        public string TechnicalMessage { get; set; }
        public string MessageId { get; set; }
        public string ShortErrorMessage { get; set; }
    }

}