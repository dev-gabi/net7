using Entities.response;

namespace Bl
{
    internal static class Utils
    {
        internal static UiResponse GenerateSuccessResponse()
        {
            return new UiResponse()
            {
                ResponseCode = 200,
                Message = "Success"
            };
        }

        internal static UiResponse GenerateErrorResponse()
        {
            return new UiResponse()
            {
                ResponseCode = 500,
                Message = "Internal Server Error"
            };
        }
    }
}
