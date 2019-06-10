using System.Collections.Generic;
using LottoGistAdmin.DataAccess.ViewModel;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegForecastPadObj : UserAuthObj
    {
        public int OperatorId { get; set; }
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public string ForecastDate { get; set; }
        public string WinningSet { get; set; }
        public string MachineSet { get; set; }
        public int Status { get; set; }

    }

    public class EditForecastPadObj : UserAuthObj
    {
        public int ForecastPadId { get; set; }
        public int OperatorId { get; set; }
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public string ForecastDate { get; set; }
        public string WinningSet { get; set; }
        public string MachineSet { get; set; }
        public int Status { get; set; }
    }

    //public class DeleteForecastExpertLevelObj : UserAuthObj
    //{
    //    public int ForecastExpertLevelId { get; set; }

    //}

    //***************************** Response Objects  **********************************
    public class ForecastPadSearchObj : UserAuthObj
    {
        public List<ForecastPadItemObj> ForecastPads { get; set; }
    public APIResponseStatus Status { get; set; }
    }


    public class ForecastPadItemObj
    {
        public int ForecastPadId { get; set; }
        public int OperatorId { get; set; }
        public string OperatorShortName { get; set; }
        public int GameId { get; set; }
        public string GameShortName { get; set; }
        public int GameTypeId { get; set; }
        public string GameTypeShortName { get; set; }
        public string ForecastDate { get; set; }
        public string WinningSet { get; set; }
        public string MachineSet { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<LookupModel> AllGames { get; set; }
        public List<NameValueObject> AllOperators { get; set; }
        public List<LookupModel> AllGameTypes { get; set; }
    }
}