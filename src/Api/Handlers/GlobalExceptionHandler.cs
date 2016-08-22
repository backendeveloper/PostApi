using System.Collections.Generic;
using System.Net;
using Common;
using Contract.Dtos;
using Contract.Responses;
using Microsoft.Extensions.Logging;

namespace Api.Handlers
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        private readonly ILogger _logger;

        public GlobalExceptionHandler(HttpConfiguration config)
        {
            _logger = (ILogger)config.DependencyResolver.GetService(typeof(ILogger));
        }

        

        private BaseResponse GetErrorResponse()
        {
            BaseResponse response = new BaseResponse();

            response.Errors = new List<ErrorDto>();
            response.Errors.Add(new ErrorDto(Messages.UnhandledExceptionMessage, HttpStatusCode.InternalServerError.ToString()));

            return response;
        }
    }
}