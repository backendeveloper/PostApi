using System;
using System.Collections.Generic;
using System.Linq;
using Common.Attributes;
using Common.Validations;
using Contract.Dtos;
using Contract.Responses;
using MediatR;
using ServiceLocation;
using NLog;
using System.Reflection;

namespace Common.Handlers
{
    public abstract class BaseHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse> where TResponse : BaseResponse, new()
    {
        protected IUserContext UserContext;
        protected IRequestContext RequestContext;
        protected ILogger Logger;

        public TResponse Handle(TRequest request)
        {
            InitializeDependencies();

            TResponse response;

            BusinessValidationResult validationResult = ExecuteBusinessValidator(request);

            if (validationResult.IsValid)
            {
                try
                {
                    response = Execute(request);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "RequestId: {0}", RequestContext.RequestId);

                    response = GetErrorResponse(request, ex);
                }
            }
            else
            {
                response = GetErrorResponse(request, validationResult);
            }

            return response;
        }

        public abstract TResponse Execute(TRequest request);

        private void InitializeDependencies()
        {
            Logger = LogManager.GetLogger(GetType().Name);
            UserContext = ServiceLocator.Current.GetInstance<IUserContext>();
            RequestContext = ServiceLocator.Current.GetInstance<IRequestContext>();
        }

        private BusinessValidationResult ExecuteBusinessValidator(TRequest request)
        {
            BusinessValidationResult result = new BusinessValidationResult();

            ValidateRequestAttribute validateRequestDefinition = GetValidatorDefinition();

            if (validateRequestDefinition != null)
            {
                List<IBusinessValidator<TRequest>> validators = GetValidators();

                if (validators.Any())
                {
                    if (validators.Count > 1)
                    {
                        throw new InvalidOperationException("Every request message that implements IRequest can have only 1 IBusinessValidator implemented for its request.");
                    }

                    BusinessValidationResult validationResult = validators.Single().Validate(request);

                    if (!validationResult.IsValid)
                    {
                        result = validationResult;
                    }
                }
            }

            return result;
        }

        private List<IBusinessValidator<TRequest>> GetValidators()
        {
            IEnumerable<IBusinessValidator<TRequest>> validatorObjects = ServiceLocator.Current.GetAllInstances<IBusinessValidator<TRequest>>();
            return validatorObjects.ToList();
        }

        private ValidateRequestAttribute GetValidatorDefinition()
        {
            Type type = this.GetType();

            object[] attributeObjects = new[] { type.GetTypeInfo().GetCustomAttribute(typeof(ValidateRequestAttribute), false) };

            ValidateRequestAttribute result = null;

            if (attributeObjects.Any())
            {
                result = (ValidateRequestAttribute)attributeObjects.First();
            }

            return result;
        }

        private TResponse GetErrorResponse(TRequest request, BusinessValidationResult validationResult)
        {
            if (validationResult.Errors.Any())
            {
                throw new InvalidOperationException("GetErrorResponse should be called with a validationResult which has errors.");
            }

            TResponse response = new TResponse();

            response.AddErrors(validationResult.Errors);

            return response;
        }

        private TResponse GetErrorResponse(TRequest request, Exception ex)
        {
            TResponse response = new TResponse();

            response.Errors.Add(new ErrorDto($"Bir sorun oluştu. Detaylı bilg için: {RequestContext.RequestId}", Constants.Error.UnexpectedErrorKey));

            return response;
        }
    }
}
