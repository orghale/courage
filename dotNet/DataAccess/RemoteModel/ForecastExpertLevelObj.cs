using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegForecastExpertLevelObj : UserAuthObj
    {
        public int RequiredPoints { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

    }

    public class EditForecastExpertLevelObj : UserAuthObj
    {
        public int ForecastExpertLevelId { get; set; }
        public int RequiredPoints { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }

    public class DeleteForecastExpertLevelObj : UserAuthObj
    {
        public int ForecastExpertLevelId { get; set; }

    }

    //***************************** Response Objects  **********************************
    public class ForecastExpertLevelSearchObj : UserAuthObj
    {
        public List<ForecastExpertLevelItemObj> ForecastExpertLevels { get; set; }
    public APIResponseStatus Status { get; set; }
    }


    public class ForecastExpertLevelItemObj
    {
        public int ForecastExpertLevelId { get; set; }
        public int RequiredPoints { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
       
    }
}