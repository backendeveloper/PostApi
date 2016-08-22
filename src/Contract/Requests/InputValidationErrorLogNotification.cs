using Contract.Responses;
using MediatR;

namespace Contract.Requests
{
    public class InputValidationErrorLogNotification : INotification
    {
        public InputValidationErrorResponse Data { get; set; }
    }
}