using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegGameTypeObj : UserAuthObj
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }

    }

    public class EditGameTypeObj : UserAuthObj
    {
        public int GameTypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        //public string StatusVal { get; set; }


    }

    public class DeleteGameTypeObj : UserAuthObj
    {
        public int GameTypeId { get; set; }
       
    }

    //***************************** Response Objects  **********************************
    public class GameTypeRespObj
    {
        public List<GameTypeItemObj> GameTypes { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class GameTypeItemObj
    {
        public int GameTypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

    }
}