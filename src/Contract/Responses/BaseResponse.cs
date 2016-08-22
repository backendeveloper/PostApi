using System.Collections.Generic;
using Contract.Dtos;

namespace Contract.Responses
{
    public class BaseResponse
    {
        public List<ErrorDto> Errors { get; set; }

        public void AddErrors(List<ErrorDto> errors)
        {
            if (Errors == null)
            {
                Errors = new List<ErrorDto>();
            }

            Errors.AddRange(errors);
        }
    }
}