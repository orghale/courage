using System;
using System.Configuration;
using System.Net;
using LottoGistAdmin.DataAccess.ExternalTool;
using LottoGistAdmin.DataAccess.RemoteModel;
using RestSharp;
using XPLUG.WEBTOOLKIT;

namespace LottoGistAdmin.DataAccess.RemoteManager
{
    public class RemoteEndPointService
    {
        private readonly RestClient _client;
        private readonly RestRequest _request;
        private readonly string _baseUrl = ConfigurationManager.AppSettings.Get("remoteServerAddress");

        #region Remote Endpoint Service

        public RemoteEndPointService(string endpoint, string auth, Method method)
        {
            if (string.IsNullOrEmpty(_baseUrl) || _baseUrl.Length < 5)
            {
                throw new ApplicationException("Remote Server Address Not Configured");
            }

            _client = new RestClient(_baseUrl);

            _request = new RestRequest(endpoint, method)
            {
                JsonSerializer = new JsonSerializer(),
                RequestFormat = DataFormat.Json
            };

            _request.AddHeader("content-type", "application/json");
            _request.AddHeader("Authorization", "Bearer " + auth);
            _request.Timeout = 180000;


            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }
        #endregion

        #region Game Type

        internal SettingRegRespObj AddGameTypeService(RegGameTypeObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateGameTypeService(EditGameTypeObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj DeleteGameTypeService(DeleteGameTypeObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal GameTypeRespObj LoadGameTypesService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<GameTypeRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        #endregion

        #region Operator

        internal SettingRegRespObj AddOperatorService(RegOperatorObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateOperatorService(EditOperatorObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj DeleteOperatorService(DeleteOperatorObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal OperatorRespObj LoadOperatorsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<OperatorRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region Game Schedule

        internal SettingRegRespObj AddGameScheduleService(RegGameScheduleObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateGameScheduleService(EditGameScheduleObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj DeleteGameScheduleService(DeleteGameScheduleObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal GameScheduleRespObj LoadGameSchedulesService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<GameScheduleRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region Game

        internal SettingRegRespObj AddGameService(RegGameObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateGameService(EditGameObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj DeleteGameService(DeleteGameObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal GameRespObj LoadGamesService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<GameRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region EChart

        internal SettingRegRespObj AddEchartService(RegEChartObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateEChartService(EditEChartObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj DeleteEChartService(DeleteEChartObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal EChartRespObj LoadEChartsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<EChartRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion 

        #region Chart Item

        internal SettingRegRespObj AddChartItemService(RegEChartItemObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateChartItemService(EditEChartItemObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj DeleteChartItemService(DeleteEChartItemObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal EChartItemSearchObj LoadChartItemsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<EChartItemSearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region Chart Selection

        //internal SettingRegRespObj AddChartSelectionService(RegChartSelectionObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        ////internal SettingRegRespObj UpdateChartSelectionService(EditChartSelectionObj serviceObj, out string msg)
        ////{
        ////    try
        ////    {
        ////        _request.AddBody(serviceObj);
        ////        var response = _client.Execute(_request);
        ////        var responseCode = (int)response.StatusCode;
        ////        if (responseCode >= 200 && responseCode < 300)
        ////        {
        ////            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        ////            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        ////            return deserializedResponse;
        ////        }

        ////        var exception = new RequestResponseHelper().ReadRequestException(response);
        ////        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        ////        return null;
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        ////        msg = "Unable to complete your request due to error! Please try again later ";
        ////        return null;
        ////    }
        ////}

        //internal SettingRegRespObj DeleteChartSelectionService(DeleteChartSelectionObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //internal ChartSelectionSearchObj LoadChartSelectionsService(SettingSearchObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<ChartSelectionSearchObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        #endregion 

        #region Blog Category

        internal SettingRegRespObj AddBlogCategoryService(RegBlogCategoryObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateBlogCategoryService(EditBlogCategoryObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        //internal SettingRegRespObj UpdateBlogCategoryFrequencyService(UpdateBlogCategoryFreqObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        internal SettingRegRespObj DeleteBlogCategoryService(DeleteBlogCategoryObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal BlogCategorySearchObj LoadBlogCategoriesService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<BlogCategorySearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region Blog Post

        internal SettingRegRespObj AddBlogPostService(RegBlogPostObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateBlogPostService(EditBlogPostObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        //internal SettingRegRespObj UpdateBlogPostFrequencyService(UpdateBlogPostFreqObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        internal SettingRegRespObj DeleteBlogPostService(DeleteBlogPostObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal BlogPostSearchObj LoadBlogPostsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<BlogPostSearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region Blog Topic

        internal SettingRegRespObj AddBlogTopicService(RegBlogTopicObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateBlogTopicService(EditBlogTopicObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        //internal SettingRegRespObj UpdateBlogTopicFrequencyService(UpdateBlogTopicFreqObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        internal SettingRegRespObj DeleteBlogTopicService(DeleteBlogTopicObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal BlogTopicSearchObj LoadBlogTopicsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<BlogTopicSearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion 

        #region User

        //internal SettingRegRespObj AddUserService(RegUserObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //internal SettingRegRespObj UpdateUserService(EditUserObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //internal SettingRegRespObj UserLoginService(UsersLoginObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        ////internal SettingRegRespObj DeleteUserService(DeleteUserObj serviceObj, out string msg)
        ////{
        ////    try
        ////    {
        ////        _request.AddBody(serviceObj);
        ////        var response = _client.Execute(_request);
        ////        var responseCode = (int)response.StatusCode;
        ////        if (responseCode >= 200 && responseCode < 300)
        ////        {
        ////            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        ////            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        ////            return deserializedResponse;
        ////        }

        ////        var exception = new RequestResponseHelper().ReadRequestException(response);
        ////        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        ////        return null;
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        ////        msg = "Unable to complete your request due to error! Please try again later ";
        ////        return null;
        ////    }
        ////}

        //internal UsersSearchObj LoadUsersService(SettingSearchObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<UsersSearchObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        #endregion 

        #region Forecast Expert Level

        internal SettingRegRespObj AddForecastExpertLevelService(RegForecastExpertLevelObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal SettingRegRespObj UpdateForecastExpertLevelService(EditForecastExpertLevelObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj DeleteForecastExpertLevelService(DeleteForecastExpertLevelObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        internal ForecastExpertLevelSearchObj LoadForecastExpertLevelsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<ForecastExpertLevelSearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        //#region Forecast Pad

        //internal SettingRegRespObj AddForecastPadService(RegForecastPadObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //internal SettingRegRespObj UpdateForecastPadService(EditForecastPadObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        ////internal SettingRegRespObj DeleteForecastPadService(DeleteForecastPadObj serviceObj, out string msg)
        ////{
        ////    try
        ////    {
        ////        _request.AddBody(serviceObj);
        ////        var response = _client.Execute(_request);
        ////        var responseCode = (int)response.StatusCode;
        ////        if (responseCode >= 200 && responseCode < 300)
        ////        {
        ////            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        ////            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        ////            return deserializedResponse;
        ////        }

        ////        var exception = new RequestResponseHelper().ReadRequestException(response);
        ////        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        ////        return null;
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        ////        msg = "Unable to complete your request due to error! Please try again later ";
        ////        return null;
        ////    }
        ////}

        //internal ForecastPadSearchObj LoadForecastPadsService(SettingSearchObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<ForecastPadSearchObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //#endregion

        //#region Forecast Room

        //internal SettingRegRespObj AddForecastRoomService(RegForecastRoomObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        //internal SettingRegRespObj UpdateForecastRoomService(EditForecastRoomObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        //internal SettingRegRespObj DeleteForecastRoomService(DeleteForecastRoomObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}
        //internal ForecastRoomSearchObj LoadForecastRoomsService(SettingSearchObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<ForecastRoomSearchObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //#endregion

        #region Lotto School Category 

        internal SettingRegRespObj AddLottoSchoolCategoryService(RegLottoSchoolCategoryObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj UpdateLottoSchoolCategoryService(EditLottoSchoolCategoryObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj DeleteLottoSchoolCategoryService(DeleteLottoSchoolCategoryObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal LottoSchoolCategorySearchObj LoadLottoSchoolCategoriesService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<LottoSchoolCategorySearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        //#region Lotto School Comment Approval
        //internal LottoSchoolCommentApprovalSearchObj LoadLottoSchoolCommentsApprovalService(SettingSearchObj serviceObj, out string msg)
        //{
        //    try
        //    {
        //        _request.AddBody(serviceObj);
        //        var response = _client.Execute(_request);
        //        var responseCode = (int)response.StatusCode;
        //        if (responseCode >= 200 && responseCode < 300)
        //        {
        //            var deserializedResponse = new RequestResponseHelper().Deserialize<LottoSchoolCommentApprovalSearchObj>(response, null, out msg);
        //            msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
        //            return deserializedResponse;
        //        }

        //        var exception = new RequestResponseHelper().ReadRequestException(response);
        //        msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
        //        msg = "Unable to complete your request due to error! Please try again later ";
        //        return null;
        //    }
        //}

        //#endregion

        #region Lotto School Category 

        internal SettingRegRespObj AddLottoSchoolItemService(RegLottoSchoolItemObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj UpdateLottoSchoolItemService(EditLottoSchoolItemObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj DeleteLottoSchoolItemService(DeleteLottoSchoolItemObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal LottoSchoolItemSearchObj LoadLottoSchoolItemsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<LottoSchoolItemSearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

        #region Lotto School Item

        internal SettingRegRespObj AddLottoSchoolTopicService(RegLottoSchoolTopicObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj UpdateLottoSchoolTopicService(EditLottoSchoolTopicObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal SettingRegRespObj DeleteLottoSchoolTopicService(DeleteLottoSchoolTopicObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<SettingRegRespObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }
        internal LottoSchoolTopicSearchObj LoadLottoSchoolTopicsService(SettingSearchObj serviceObj, out string msg)
        {
            try
            {
                _request.AddBody(serviceObj);
                var response = _client.Execute(_request);
                var responseCode = (int)response.StatusCode;
                if (responseCode >= 200 && responseCode < 300)
                {
                    var deserializedResponse = new RequestResponseHelper().Deserialize<LottoSchoolTopicSearchObj>(response, null, out msg);
                    msg = deserializedResponse == null ? "" : deserializedResponse.Status == null ? "" : deserializedResponse.Status.Message == null ? "" : deserializedResponse.Status.Message.FriendlyMessage ?? "";
                    return deserializedResponse;
                }

                var exception = new RequestResponseHelper().ReadRequestException(response);
                msg = exception == null ? "Unknown Exception Occurred!" : exception.Message;
                return null;
            }
            catch (Exception ex)
            {
                UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
                msg = "Unable to complete your request due to error! Please try again later ";
                return null;
            }
        }

        #endregion

    }
}