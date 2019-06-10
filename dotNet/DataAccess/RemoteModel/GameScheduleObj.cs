using System.Collections.Generic;
using LottoGistAdmin.DataAccess.ViewModel;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegGameScheduleObj : UserAuthObj
    {
        public int GameId { get; set; }
        public int OperatorId { get; set; }
        public int GameDay { get; set; }
        public int ScheduleOrder { get; set; }
        public string ScheduleTime { get; set; }
        public int Status { get; set; }
    }

    public class EditGameScheduleObj : UserAuthObj
    {
        public int GameScheduleId { get; set; }
        public int GameId { get; set; }
        public int OperatorId { get; set; }
        public int GameDay { get; set; }
        public int ScheduleOrder { get; set; }
        public string ScheduleTime { get; set; }
        public int Status { get; set; }

    }

    public class DeleteGameScheduleObj : UserAuthObj
    {
        public int GameScheduleId { get; set; }
    }

    //***************************** Response Objects  **********************************
    public class GameScheduleRespObj
    {
        public List<GameScheduleItemObj> GameSchedules { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class GameScheduleItemObj
    {
        public int GameScheduleId { get; set; }
        public int GameId { get; set; }
        public string  GameName { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int GameDay { get; set; }
        public string GameDayLabel { get; set; }
        public int ScheduleOrder { get; set; }
        public bool ScheduleOrderVal { get; set; }
        public string ScheduleTime { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<LookupModel> AllGames { get; set; }
        public List<NameValueObject> AllOperators { get; set; }

        //public int[] MyGameIds { get; set; }
        //public string[] MyGame { get; set; }
        //public int[] MyOperatorIds { get; set; }
        //public string[] MyOperator { get; set; }

    }
}