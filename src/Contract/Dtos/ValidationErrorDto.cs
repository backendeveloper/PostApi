namespace Contract.Dtos
{
    public class ValidationErrorDto : ErrorDto
    {
        public string Field { get; set; }

        // TODO Remove magic string.
        public ValidationErrorDto(string field, string displayMessage) : base(displayMessage, "InputValidationError")
        {
            Field = field;
        }
    }
}