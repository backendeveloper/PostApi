using System.Collections.Generic;
using System.Linq;
using Contract.Dtos;

namespace Common.Validations
{
    public class BusinessValidationResult
    {
        public bool IsValid => Errors.Any();

        public List<ErrorDto> Errors { get; set; }

        public void AddError(string displayMessage, string code = Constants.Validation.BusinessValidationErrorKey)
        {
            if (Errors == null)
            {
                Errors = new List<ErrorDto>();
            }

            Errors.Add(new ErrorDto(displayMessage, code));
        }
    }
}