using System.Collections.Generic;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegForecastRoomObj : UserAuthObj
    {
        public int OperatorId { get; set; }
        public string Title { get; set; }
       public int Status { get; set; }

    }

    public class EditForecastRoomObj : UserAuthObj
    {
        public int ForecastRoomId { get; set; }
        public int OperatorId { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
    }

    public class DeleteForecastRoomObj : UserAuthObj
    {
        public int ForecastRoomId { get; set; }

    }

    //***************************** Response Objects  **********************************
    public class ForecastRoomSearchObj : UserAuthObj
    {
        public List<ForecastRoomItemObj> ForecastRooms { get; set; }
    public APIResponseStatus Status { get; set; }
    }


    public class ForecastRoomItemObj
    {
        public int ForecastRoomId { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<NameValueObject> AllOperators { get; set; }
    }
}