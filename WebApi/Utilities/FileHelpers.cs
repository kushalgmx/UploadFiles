using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;

namespace WebApi.Utilities
{
    public class FileHelpers
    {
        public bool ProcessStreamedFile(MultipartSection section, ContentDispositionHeaderValue? headerValue, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState)
        {
            return false;
        }
    }
}
