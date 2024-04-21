﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityInfrastructure {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IdentityInfrastructure.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The &apos;Password&apos; is either missing or invalid.
        /// </summary>
        internal static string AuthenticatePasswordRequestValidator_InvalidPassword {
            get {
                return ResourceManager.GetString("AuthenticatePasswordRequestValidator_InvalidPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Username&apos; is either missing or invalid.
        /// </summary>
        internal static string AuthenticatePasswordRequestValidator_InvalidUsername {
            get {
                return ResourceManager.GetString("AuthenticatePasswordRequestValidator_InvalidUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;AuthCode&apos; is invalid or missing.
        /// </summary>
        internal static string AuthenticateSingleSignOnRequestValidator_InvalidAuthCode {
            get {
                return ResourceManager.GetString("AuthenticateSingleSignOnRequestValidator_InvalidAuthCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;InvitationToken&apos; is either missing or invalid.
        /// </summary>
        internal static string AuthenticateSingleSignOnRequestValidator_InvalidInvitationToken {
            get {
                return ResourceManager.GetString("AuthenticateSingleSignOnRequestValidator_InvalidInvitationToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Provider&apos; is invalid or missing.
        /// </summary>
        internal static string AuthenticateSingleSignOnRequestValidator_InvalidProvider {
            get {
                return ResourceManager.GetString("AuthenticateSingleSignOnRequestValidator_InvalidProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Username&apos; is invalid.
        /// </summary>
        internal static string AuthenticateSingleSignOnRequestValidator_InvalidUsername {
            get {
                return ResourceManager.GetString("AuthenticateSingleSignOnRequestValidator_InvalidUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Password&apos; is either missing or invalid.
        /// </summary>
        internal static string CompletePasswordResetRequestValidator_InvalidPassword {
            get {
                return ResourceManager.GetString("CompletePasswordResetRequestValidator_InvalidPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Token&apos; is either missing or invalid.
        /// </summary>
        internal static string CompletePasswordResetRequestValidator_InvalidToken {
            get {
                return ResourceManager.GetString("CompletePasswordResetRequestValidator_InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Token&apos; is either missing or invalid.
        /// </summary>
        internal static string ConfirmPersonRegistrationRequestValidator_InvalidToken {
            get {
                return ResourceManager.GetString("ConfirmPersonRegistrationRequestValidator_InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;ExpiresOnUtc&apos; must be between &apos;{0}hr&apos; and &apos;{1}hrs&apos;.
        /// </summary>
        internal static string CreateAPIKeyRequestValidator_InvalidExpiresOn {
            get {
                return ResourceManager.GetString("CreateAPIKeyRequestValidator_InvalidExpiresOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;EmailAddress&apos; is either missing or invalid.
        /// </summary>
        internal static string InitiatePasswordResetRequestValidator_InvalidEmailAddress {
            get {
                return ResourceManager.GetString("InitiatePasswordResetRequestValidator_InvalidEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;RefreshToken&apos; is invalid or missing.
        /// </summary>
        internal static string RefreshTokenRequestValidator_InvalidToken {
            get {
                return ResourceManager.GetString("RefreshTokenRequestValidator_InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;CountryCode&apos; is not a valid ISO3166 alpha-2 or alpha-3 code or numeric.
        /// </summary>
        internal static string RegisterAnyRequestValidator_InvalidCountryCode {
            get {
                return ResourceManager.GetString("RegisterAnyRequestValidator_InvalidCountryCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Timezone&apos; is not a valid IANA name.
        /// </summary>
        internal static string RegisterAnyRequestValidator_InvalidTimezone {
            get {
                return ResourceManager.GetString("RegisterAnyRequestValidator_InvalidTimezone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;ApiKeyExpiresOnUtc&apos; must be between &apos;{0}hr&apos; and &apos;{1}hrs&apos;.
        /// </summary>
        internal static string RegisterMachineRequestValidator_InvalidExpiresOn {
            get {
                return ResourceManager.GetString("RegisterMachineRequestValidator_InvalidExpiresOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Name&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterMachineRequestValidator_InvalidName {
            get {
                return ResourceManager.GetString("RegisterMachineRequestValidator_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Email&apos; is either missing or is an invalid email address.
        /// </summary>
        internal static string RegisterPersonPasswordRequestValidator_InvalidEmail {
            get {
                return ResourceManager.GetString("RegisterPersonPasswordRequestValidator_InvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;FirstName&apos; was either missing or is invalid.
        /// </summary>
        internal static string RegisterPersonPasswordRequestValidator_InvalidFirstName {
            get {
                return ResourceManager.GetString("RegisterPersonPasswordRequestValidator_InvalidFirstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;InvitationToken&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterPersonPasswordRequestValidator_InvalidInvitationToken {
            get {
                return ResourceManager.GetString("RegisterPersonPasswordRequestValidator_InvalidInvitationToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;LastName&apos; was either missing or is invalid.
        /// </summary>
        internal static string RegisterPersonPasswordRequestValidator_InvalidLastName {
            get {
                return ResourceManager.GetString("RegisterPersonPasswordRequestValidator_InvalidLastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Password&apos; is either missing or invalid.
        /// </summary>
        internal static string RegisterPersonPasswordRequestValidator_InvalidPassword {
            get {
                return ResourceManager.GetString("RegisterPersonPasswordRequestValidator_InvalidPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;TermsAndConditionsAccepted&apos; must be True.
        /// </summary>
        internal static string RegisterPersonPasswordRequestValidator_InvalidTermsAndConditionsAccepted {
            get {
                return ResourceManager.GetString("RegisterPersonPasswordRequestValidator_InvalidTermsAndConditionsAccepted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;RefreshToken&apos; is invalid or missing.
        /// </summary>
        internal static string RevokeRefreshTokenRequestValidator_InvalidToken {
            get {
                return ResourceManager.GetString("RevokeRefreshTokenRequestValidator_InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Username&apos; must be provided for this authentication attempt.
        /// </summary>
        internal static string TestSSOAuthenticationProvider_MissingUsername {
            get {
                return ResourceManager.GetString("TestSSOAuthenticationProvider_MissingUsername", resourceCulture);
            }
        }
    }
}
