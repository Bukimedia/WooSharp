using System;
using System.Net;

namespace Bukimedia.WooSharp
{
    public class WooSharpException : ApplicationException
    {
        public HttpStatusCode ResponseHttpStatusCode { get; set; }
        public string ResponseContent { get; set; }
        public string ResponseErrorMessage { get; set; }

        public WooSharpException()
            : base()
        {
        }

        public WooSharpException(string ResponseContent, string ResponseErrorMessage, Exception ResponseErrorException)
            : base(ResponseContent + " " + ResponseErrorMessage, ResponseErrorException)
        {
            this.ResponseContent = ResponseContent;
            this.ResponseErrorMessage = ResponseErrorMessage;
        }

        public WooSharpException(string ResponseContent, string ResponseErrorMessage, HttpStatusCode ResponseHttpStatusCode, Exception ResponseErrorException)
            : base(ResponseContent + " " + ResponseErrorMessage + " HttpStatusCode: " + ResponseHttpStatusCode, ResponseErrorException)
        {
            this.ResponseContent = ResponseContent;
            this.ResponseErrorMessage = ResponseErrorMessage;
            this.ResponseHttpStatusCode = ResponseHttpStatusCode;
        }
    }
}
