using System.Collections.Generic;
using XPLUG.WEBTOOLKIT;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegGameObj : UserAuthObj
    {
        public int GameTypeId { get; set; }
        public int OperatorId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        
    }

    public class EditGameObj : UserAuthObj
    {
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public int OperatorId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
       
    }

    public class DeleteGameObj : UserAuthObj
    {
        public int GameId { get; set; }
       
    }

    //***************************** Response Objects  **********************************
    public class GameRespObj
    {
        public List<GameItemObj> Games { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class GameItemObj
    {
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public string GameTypeName { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<NameValueObject> AllGameTypes { get; set; }
        public List<NameValueObject> AllOperators { get; set; }

    }

}