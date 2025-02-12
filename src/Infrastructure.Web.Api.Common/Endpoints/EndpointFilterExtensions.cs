using Infrastructure.Web.Api.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Web.Api.Common.Endpoints;

public static class EndpointFilterExtensions
{
    /// <summary>
    ///     Determines the request DTO of the current HTTP request.
    ///     We expect that all <see cref="RequestDelegate" /> are of this form: (IMediatr mediatr, IWebRequest request)
    ///     where the second parameter is an instance of a <see cref="IWebRequest{TResponse}" />
    /// </summary>
    public static IWebRequest? GetRequestDto(this EndpointFilterInvocationContext context)
    {
        var arguments = context.Arguments;
        if (arguments.Count < 2)
        {
            return null;
        }

        var request = context.Arguments[1]!;
        if (request is not IWebRequest webRequest)
        {
            return null;
        }

        return webRequest;
    }
}