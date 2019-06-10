using System.Collections.Generic;
using LottoGistAdmin.DataAccess.ViewModel;
using XPLUG.WEBTOOLKIT;

namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegEChartItemObj : UserAuthObj
    {
        public int EChartId { get; set; }
        public string Title { get; set; }
        public string ItemNote { get; set; }
        public string ItemNumbers { get; set; }
        public int ChartItemType { get; set; }
        public int Status { get; set; }
    }

    public class EditEChartItemObj : UserAuthObj
    {
        public int EChartItemId { get; set; }
        public int EChartId { get; set; }
        public string Title { get; set; }
        public string ItemNote { get; set; }
        public string ItemNumbers { get; set; }
        public int ChartItemType { get; set; }
        public int Status { get; set; }
    }

    public class DeleteEChartItemObj : UserAuthObj
    {
        public int EChartItemId { get; set; }
    }

    //***************************** Response Objects  **********************************
    public class EChartItemSearchObj
    {
        public List<ChartItemItemObj> EChartItems { get; set; }
        public APIResponseStatus Status { get; set; }
    }
    
    public class ChartItemItemObj
    {
        public int EChartItemId { get; set; }
        public int EChartId { get; set; }
        public string EChartTitle { get; set; }
        public string Title { get; set; }
        public string ItemNote { get; set; }
        public string ItemNumbers { get; set; }
        public int ChartItemType { get; set; }
        public string ChartItemTypeLabel { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<LookupModel> AllECharts { get; set; }
        public List<NameValueObject> AllEChartIds { get; set; }
    }

}