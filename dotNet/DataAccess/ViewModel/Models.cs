using XPLUG.WEBTOOLKIT;

namespace LottoGistAdmin.DataAccess.ViewModel
{
    public class LookupModel
    {
        public int Id { get; set; }
        public int EChartId { get; set; }
        public int ChartItemType { get; set; }
        public string ChartItemTypeLabel { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public int GameDay { get; set; }
        public int ChartDate { get; set; }
        public int LottoSchoolCategoryId { get; set; }
        public int LottoSchoolTopicId { get; set; }
       
    }
}