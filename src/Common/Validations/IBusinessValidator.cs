namespace Common.Validations
{
    public interface IBusinessValidator<in T>
    {
        BusinessValidationResult Validate(T request);
    }
}