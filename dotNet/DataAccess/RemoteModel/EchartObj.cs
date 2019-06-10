using System;
using System.Collections.Generic;
using LottoGistAdmin.DataAccess.ViewModel;
using XPLUG.WEBTOOLKIT;

namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegEChartObj : UserAuthObj
    {
        public int OperatorId { get; set; }
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public int GameScheduleId { get; set; }
        public string Title { get; set; }
        public string ChartDate { get; set; }
        public string BankerValue { get; set; }
        public string TwoSureValue { get; set; }

        public string ThreeDirectValue { get; set; }
        public string PositiveOnesValue { get; set; }
        public string SuperFiveValue { get; set; }
        public string PermValue { get; set; }
        public string LastSuccessResult { get; set; }
        public string LastMachineResult { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        //public string LoginIP { get; set; }
    }

    public class EditEChartObj : UserAuthObj
    {
        public int EChartId { get; set; }
        public int OperatorId { get; set; }
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public int GameScheduleId { get; set; }
        public string Title { get; set; }
        public string ChartDate { get; set; }
        public string BankerValue { get; set; }
        public string TwoSureValue { get; set; }
        public string ThreeDirectValue { get; set; }
        public string PositiveOnesValue { get; set; }
        public string SuperFiveValue { get; set; }
        public string PermValue { get; set; }
        public string LastSuccessResult { get; set; }
        public string LastMachineResult { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }

    public class DeleteEChartObj : UserAuthObj
    {
        public int EChartId { get; set; }
    }

    //***************************** Response Objects  **********************************
    public class EChartRespObj
    {
        public List<EChartItemObj> ECharts { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class EChartItemObj
    {
        public int EChartId { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GameTypeId { get; set; }
        public string GameTypeName { get; set; }
        public int GameScheduleId { get; set; }
        public string GameScheduleDate { get; set; }
        public string Title { get; set; }
        public string ChartDate { get; set; }
        public DateTime TheChartDate { get; set; }
        //------------BANKER-------------------
        public string BankerValue { get; set; }
        //------------tWO SURE------------------
        public string TwoSureValue { get; set; }
        public string TwoSureValueA { get; set; }
        public string TwoSureValueB { get; set; }
        //-------------THREE DIRECT--------------
        public string ThreeDirectValue { get; set; }
        public string ThreeDirectValueA { get; set; }
        public string ThreeDirectValueB { get; set; }
        public string ThreeDirectValueC { get; set; }
        //-------------ONES-----------------------
        public string PositiveOnesValue { get; set; }
        public string PositiveOnesValueA { get; set; }
        public string PositiveOnesValueB { get; set; }
        public string PositiveOnesValueC { get; set; }
        public string PositiveOnesValueD { get; set; }
        public string PositiveOnesValueE { get; set; }
        //----------------FIVE--------------------
        public string SuperFiveValue { get; set; }
        public string SuperFiveValueA { get; set; }
        public string SuperFiveValueB { get; set; }
        public string SuperFiveValueC { get; set; }
        public string SuperFiveValueD { get; set; }
        public string SuperFiveValueE { get; set; }
        //----------------PERM--------------------
        public string PermValue { get; set; }
        public string PermValueA { get; set; }
        public string PermValueB { get; set; }
        public string PermValueC { get; set; }
        public string PermValueD { get; set; }
        public string PermValueE { get; set; }
        //----------------SUCCESS--------------------
        public string LastSuccessResultA { get; set; }
        public string LastSuccessResultB { get; set; }
        public string LastSuccessResultC { get; set; }
        public string LastSuccessResultD { get; set; }
        public string LastSuccessResultE { get; set; }
        public string LastSuccessResult { get; set; }
        //----------------MACHINE--------------------
        public string LastMachineResultA { get; set; }
        public string LastMachineResultB { get; set; }
        public string LastMachineResultC { get; set; }
        public string LastMachineResultD { get; set; }
        public string LastMachineResultE { get; set; }
        public string LastMachineResult { get; set; }

        public string Message { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }

        public List<LookupModel> AllGames { get; set; }
        public List<NameValueObject> AllOperators { get; set; }
        public List<LookupModel> AllGameSchedules { get; set; }


        public string[] MyGame { get; set; }
        public string[] MyOperator { get; set; }
        public string[] MyGameSchedule { get; set; }
        public string[] MyEChart { get; set; }
    }

}