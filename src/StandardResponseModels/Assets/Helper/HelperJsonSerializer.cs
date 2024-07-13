using StandardResponseModels.Assets.Models;
using System.Text.Json;

namespace StandardResponseModels.Assets.Helper
{
    internal static class HelperJsonSerializer
    {
        internal static string SerializeResult(IRequestResult result)
        {
            string jsonResult = JsonSerializer.Serialize(result);
            return jsonResult;
        }
    }
}
