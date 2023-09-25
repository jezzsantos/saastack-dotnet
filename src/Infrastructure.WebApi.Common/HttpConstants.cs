namespace Infrastructure.WebApi.Common;

/// <summary>
///     Common HTTP MimeTypes
/// </summary>
public static class HttpContentTypes
{
    public const string Json = "application/json";
    public const string JsonWithCharset = "application/json; charset=utf-8";
    public const string OctetStream = "application/octet-stream";
    public const string Xml = "application/xml";
    public const string XmlWithCharset = "application/xml; charset=utf-8";
}

/// <summary>
///     Common HTTP headers
/// </summary>
public static class HttpHeaders
{
    public const string Accept = "Accept";
}

/// <summary>
///     Known query parameters
/// </summary>
public static class HttpQueryParams
{
    public const string Format = "format";
}

/// <summary>
///     Known content negotiation formatters
/// </summary>
public static class HttpContentTypeFormatters
{
    public const string Json = "json";
    public const string Xml = "xml";
}