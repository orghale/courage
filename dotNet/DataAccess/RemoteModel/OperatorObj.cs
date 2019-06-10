using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegOperatorObj : UserAuthObj
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public int RegisteredBy { get; set; }
        
    }

    public class EditOperatorObj : UserAuthObj
    {
        public int OperatorId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public int RegisteredBy { get; set; }

    }

    public class DeleteOperatorObj : UserAuthObj
    {
        public int OperatorId { get; set; }
       
    }

    //***************************** Response Objects  **********************************
    public class OperatorRespObj
    {
        public List<OperatorItemObj> Operators { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class OperatorItemObj
    {
        public int OperatorId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
        public int RegisteredBy { get; set; }
        public string RegisteredByLabel { get; set; }

    }
}