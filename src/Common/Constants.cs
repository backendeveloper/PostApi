namespace Common
{
    public class Constants
    {
        public static readonly int RedisDb = 0;

        public struct DsmStockService
        {
            public static readonly int DsmStockIntegrationServiceChannelTrendyolId = 2;
        }

        public struct Validation
        {
            public const string InputValidationErrorKey = "InputValidationError";
            public const string BusinessValidationErrorKey = "BusinessValidationError";
        }

        public struct Error
        {
            public const string UnexpectedErrorKey = "InternalServerError";
        }
    }
}