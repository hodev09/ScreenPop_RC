﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace ScreenpopUtil.Utilities.CustomActionResults
{
    public class NotFoundWithErrorMessageActionResult : IHttpActionResult
    {
        public NotFoundWithErrorMessageActionResult(string message, HttpRequestMessage request)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            Message = message;
            Request = request;
        }

        public string Message { get; private set; }

        public HttpRequestMessage Request { get; private set; }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
            response.Content = new StringContent(Message); // Put the message in the response body (text/plain content).
            response.RequestMessage = Request;
            return response;
        }        
    }

    public static class ApiControllerExtensions
    {
        public static NotFoundWithErrorMessageActionResult NotFound(this ApiController controller, string message)
        {
            return new NotFoundWithErrorMessageActionResult(message, controller.Request);
        }
    }
}
