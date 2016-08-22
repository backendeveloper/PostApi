using System.Collections.Generic;
using System.Linq;
using Contract.Dtos;
using Contract.Responses;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Api.Filters
{
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        private bool _enableValidationErrorLogging;

        public ValidateModelStateAttribute() : this(false) { }

        public ValidateModelStateAttribute(bool enableValidationErrorLogging)
        {
            _enableValidationErrorLogging = enableValidationErrorLogging;
        }


        public override void OnActionExecuting(ActionExecutingContext executingContext)
        {
            if (!executingContext.ModelState.IsValid)
            {
                InputValidationErrorResponse errorResponse = GetErrorResponse(executingContext.ModelState);

                if (_enableValidationErrorLogging)
                {
                    //TODO: Burası ne?
                }

                executingContext.Result = new BadRequestObjectResult(executingContext.ModelState);
            }
        }

        private InputValidationErrorResponse GetErrorResponse(ModelStateDictionary modelStates)
        {
            List<ValidationErrorDto> errors = new List<ValidationErrorDto>();
            InputValidationErrorResponse response = new InputValidationErrorResponse();

            if (modelStates.Any())
            {
                foreach (KeyValuePair<string, ModelStateEntry> state in modelStates)
                {
                    foreach (ModelError error in state.Value.Errors)
                    {
                        errors.Add(new ValidationErrorDto(state.Key, error.ErrorMessage));
                    }
                }
            }
            response.AddErrors(errors);

            return response;
        }
    }
}