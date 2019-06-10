using System;
using System.Text;
using Newtonsoft.Json;

// ReSharper disable InconsistentNaming

namespace LottoGistAdmin.DataAccess.ExternalTool
{
    [Serializable]
    public class ServiceException
    {
        /// <summary>
        /// return the distinctive error message identifier
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId;

        /// <summary>
        /// return the textual representation of the error
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text;

        /// <summary>
        /// return any instance specific error variables
        /// </summary>
        [JsonProperty(PropertyName = "variables")]
        public string[] Variables;


        /// <summary>
        /// default constructor
        /// </summary>
        public ServiceException() { }

        /// <summary>
        /// utility constructor to create a ServiceException object with all fields set </summary>
        /// <param name="messageId"> </param>
        /// <param name="text"> </param>
        /// <param name="variables"> </param>
        public ServiceException(string messageId, string text, string[] variables)
        {
            MessageId = messageId;
            Text = text;
            Variables = variables;
        }

        /// <summary>
        /// generate a textual representation of the ServiceException instance  
        /// </summary>
        public override string ToString()
        {
            var buffer = new StringBuilder();
            buffer.Append("messageId = ");
            buffer.Append(MessageId);
            buffer.Append(", text = ");
            buffer.Append(Text);
            buffer.Append(", variables = {");
            if (Variables != null)
            {
                for (var i = 0; i < Variables.Length; i++)
                {
                    buffer.Append("[");
                    buffer.Append(i);
                    buffer.Append("] = ");
                    buffer.Append(Variables[i]);
                }
            }
            buffer.Append("}");
            return buffer.ToString();
        }
    }

    [Serializable]
    public class PolicyException
    {
        /// <summary>
        /// return the distinctive error message identifier
        /// </summary>
        public string MessageId;

        /// <summary>
        /// return the textual representation of the error
        /// </summary>
        public string Text;

        /// <summary>
        /// return any instance specific error variables
        /// </summary>
        public string[] Variables;


        /// <summary>
        /// default constructor
        /// </summary>
        public PolicyException() { }

        /// <summary>
        /// utility constructor to create a ServiceException object with all fields set </summary>
        /// <param name="messageId"> </param>
        /// <param name="text"> </param>
        /// <param name="variables"> </param>
        public PolicyException(string messageId, string text, string[] variables)
        {
            MessageId = messageId;
            Text = text;
            Variables = variables;
        }

        /// <summary>
        /// generate a textual representation of the ServiceException instance  
        /// </summary>
        public override string ToString()
        {
            var buffer = new StringBuilder();
            buffer.Append("messageId = ");
            buffer.Append(MessageId);
            buffer.Append(", text = ");
            buffer.Append(Text);
            buffer.Append(", variables = {");
            if (Variables != null)
            {
                for (var i = 0; i < Variables.Length; i++)
                {
                    buffer.Append("[");
                    buffer.Append(i);
                    buffer.Append("] = ");
                    buffer.Append(Variables[i]);
                }
            }
            buffer.Append("}");
            return buffer.ToString();
        }
    }
    public class RequestException : Exception
    {
        public RequestException()
        {
        }

        public RequestException(string s)
            : base(s)
        {
        }

        public RequestException(Exception e)
            : base(e.Message, e)
        {
        }

        public RequestException(string s, Exception e)
            : base(s, e)
        {
        }

        public RequestException(Exception e, int responseCode)
            : base(e.Message, e)
        {
            ResponseCode = responseCode;
        }

        public RequestException(string s, string messageId)
            : base(s)
        {
            MessageId = messageId;
        }

        public RequestException(string errorText, string messageId, int responseCode)
            : this(errorText)
        {
            MessageId = messageId;
            ResponseCode = responseCode;
        }

        public virtual string MessageId { get; }

        public virtual int ResponseCode { get; }
    }

    [Serializable]
    public class RequestError
    {
        /// <summary>
        /// internally used to indicate the type of exception being stored is a ServiceException
        /// </summary>
        public const int SERVICEEXCEPTION = 1;
        /// <summary>
        /// internally used to indicate the type of exception being stored is a PolicyException
        /// </summary>
        public const int POLICYEXCEPTION = 2;

        /**
        * instance of a ServiceException
        */
        private ServiceException serviceException;
        /** 
         * instance of a PolicyException
        */
        private PolicyException policyException;

        /// <summary>
        /// return the clientCorrelator
        /// </summary>
        [JsonProperty(PropertyName = "clientCorrelator")]
        public string ClientCorrelator;

        [JsonProperty(PropertyName = "serviceException")]
        public ServiceException ServiceException
        {
            get => serviceException;
            set
            {
                ExceptionType = SERVICEEXCEPTION;
                serviceException = value;
            }
        }

        [JsonIgnore]
        public int ExceptionType;

        [JsonIgnore]
        public int HttpResponseCode;

        /// <summary>
        /// return the policyException instance
        /// </summary>
        [JsonProperty(PropertyName = "policyException")]
        public PolicyException PolicyException
        {
            get => policyException;
            set
            {
                policyException = value;
                ExceptionType = POLICYEXCEPTION;
            }
        }

        /// <summary>
        /// utility constructor to create an RequestError instance with all fields set </summary>
        /// <param name="type"> </param>
        /// <param name="httpResponseCode"> </param>
        /// <param name="messageId"> </param>
        /// <param name="clientCorrelator"></param>
        /// <param name="text"> </param>
        /// <param name="variables"> </param>
        public RequestError(int type, int httpResponseCode, string messageId, string clientCorrelator, string text, params string[] variables)
        {
            if (type == SERVICEEXCEPTION)
            {
                serviceException = new ServiceException
                {
                    MessageId = messageId,
                    Text = text,
                    Variables = variables
                };
            }
            else if (type == POLICYEXCEPTION)
            {
                policyException = new PolicyException
                {
                    MessageId = messageId,
                    Text = text,
                    Variables = variables
                };
            }
            ExceptionType = type;
            ClientCorrelator = clientCorrelator;
            HttpResponseCode = httpResponseCode;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public RequestError()
        {
            HttpResponseCode = 400;
            ExceptionType = 0;
        }

        /// <summary>
        /// generate a textual representation of the RequestError including all nested elements and classes 
        /// </summary>
        public override string ToString()
        {
            var buffer = new StringBuilder();
            if (ClientCorrelator != null)
            {
                buffer.Append("clientCorrelator=");
                buffer.Append(ClientCorrelator);
            }
            if (serviceException != null)
            {
                buffer.Append("serviceException = {");
                buffer.Append("messageId = ");
                buffer.Append(serviceException.MessageId);
                buffer.Append(", text = ");
                buffer.Append(serviceException.Text);
                buffer.Append(", variables = ");
                if (serviceException.Variables != null)
                {
                    buffer.Append("{");
                    for (var i = 0; i < serviceException.Variables.Length; i++)
                    {
                        buffer.Append("[");
                        buffer.Append(i);
                        buffer.Append("] = ");
                        buffer.Append(serviceException.Variables[i]);
                    }
                    buffer.Append("}");
                }
                buffer.Append("}");
            }
            if (policyException != null)
            {
                buffer.Append("policyException = {");
                buffer.Append("messageId = ");
                buffer.Append(policyException.MessageId);
                buffer.Append(", text = ");
                buffer.Append(policyException.Text);
                buffer.Append(", variables = ");
                if (policyException.Variables != null)
                {
                    buffer.Append("{");
                    for (var i = 0; i < policyException.Variables.Length; i++)
                    {
                        buffer.Append("[");
                        buffer.Append(i);
                        buffer.Append("] = ");
                        buffer.Append(policyException.Variables[i]);
                    }
                    buffer.Append("}");
                }
                buffer.Append("}");
            }

            return buffer.ToString();
        }
    }

    
}
