using System.Collections.Generic;
using LottoGistAdmin.DataAccess.ViewModel;
using XPLUG.WEBTOOLKIT;

namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegChartSelectionObj : UserAuthObj
    {
        public int OperatorId { get; set; }
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public string SelectionDate { get; set; }
        public string DrawResultIds { get; set; }
        public string LoginIP { get; set; }
    }

   
    public class DeleteChartSelectionObj : UserAuthObj
    {
        public int ChartSelectionId { get; set; }
    }

    //***************************** Response Objects  **********************************
    public class ChartSelectionSearchObj
    {
        public List<ChartSelectionItemObj> ChartSelections { get; set; }
        public APIResponseStatus Status { get; set; }
        public int ChartSelectionId { get; set; }
        public int OperatorId { get; set; }
        public int GameId { get; set; }
        public string SelectionDate { get; set; }
        
    }


    public class ChartSelectionItemObj
    {
        public int ChartSelectionId { get; set; }
        public string EChatSelectionTitle { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GameTypeId { get; set; }
        public string GameTypeName { get; set; }
        public string SelectionDate { get; set; }
        public string DrawResultIds { get; set; }

        public List<NameValueObject> AllChartSelections { get; set; }
       
        public string[] MyChartSelection { get; set; }
    }

}