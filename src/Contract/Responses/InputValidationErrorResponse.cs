using System.Collections.Generic;
using Contract.Dtos;

namespace Contract.Responses
{
    public class InputValidationErrorResponse
    {
        public List<ValidationErrorDto> Errors { get; set; }

        public void AddErrors(List<ValidationErrorDto> errors)
        {
            if (Errors == null)
            {
                Errors = new List<ValidationErrorDto>();
            }

            Errors.AddRange(errors);
        }
    }
}