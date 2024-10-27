﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Web.Api.Interfaces {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Infrastructure.Web.Api.Interfaces.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request has been received but not yet acted upon.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_Accepted {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_Accepted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server cannot or will not process the request due to something that is perceived to be a client error.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_BadRequest {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_BadRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request conflicts with the current state of the resource.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_Conflict {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_Conflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request succeeded, and a new resource was created as a result.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_Created {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_Forbidden {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_Forbidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected error occured on the server, which should not have happened in normal operation.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_InternalServerError {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_InternalServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current resource is locked and cannot be accessed.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_Locked {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_Locked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request is not allowed by the current state of the resource.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_MethodNotAllowed {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_MethodNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no content to send for this request, but the headers may be useful.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_NoContent {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_NoContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server cannot find the requested resource.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_NotFound {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request succeeded.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_OK {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client must have payment information to get ther requested response.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_PaymentRequired {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_PaymentRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client has made too many requests in a specific timeframe.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_TooManyRequests {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_TooManyRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client must authenticate itself to get the requested response.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_Unauthorized {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_Unauthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client has made a request to Accept a media type that is not supported by the server.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Reason_UnsupportedMediaType {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Reason_UnsupportedMediaType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accepted.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_Accepted {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_Accepted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad Request.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_BadRequest {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_BadRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conflict.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_Conflict {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_Conflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_Created {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forbidden.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_Forbidden {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_Forbidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Server Error.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_InternalServerError {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_InternalServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locked.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_Locked {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_Locked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method Not Allowed.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_MethodNotAllowed {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_MethodNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Content.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_NoContent {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_NoContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Found.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_NotFound {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_OK {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payment Required.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_PaymentRequired {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_PaymentRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too Many Requests.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_TooManyRequests {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_TooManyRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unauthorized.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_Unauthorized {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_Unauthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported MediaType.
        /// </summary>
        internal static string HttpConstants_StatusCodes_Title_UnsupportedMediaType {
            get {
                return ResourceManager.GetString("HttpConstants_StatusCodes_Title_UnsupportedMediaType", resourceCulture);
            }
        }
    }
}
