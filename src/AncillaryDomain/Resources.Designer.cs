﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AncillaryDomain {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AncillaryDomain.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The email has already been delivered.
        /// </summary>
        internal static string EmailDeliveryRoot_AlreadyDelivered {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_AlreadyDelivered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email has already been sent for delivery.
        /// </summary>
        internal static string EmailDeliveryRoot_AlreadySent {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_AlreadySent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email message is missing a &apos;Body&apos;.
        /// </summary>
        internal static string EmailDeliveryRoot_HtmlEmail_MissingBody {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_HtmlEmail_MissingBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email message is missing a &apos;Subject&apos;.
        /// </summary>
        internal static string EmailDeliveryRoot_HtmlEmail_MissingSubject {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_HtmlEmail_MissingSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email sending has not yet been attempted.
        /// </summary>
        internal static string EmailDeliveryRoot_NotAttempted {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_NotAttempted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email has not yet been sent.
        /// </summary>
        internal static string EmailDeliveryRoot_NotSent {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_NotSent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email message is missing a &apos;TemplateId&apos;.
        /// </summary>
        internal static string EmailDeliveryRoot_TemplatedEmail_MissingTemplateId {
            get {
                return ResourceManager.GetString("EmailDeliveryRoot_TemplatedEmail_MissingTemplateId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ID of the message is invalid.
        /// </summary>
        internal static string QueuedMessageId_InvalidId {
            get {
                return ResourceManager.GetString("QueuedMessageId_InvalidId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The latest attempt must be after the last attempt.
        /// </summary>
        internal static string SendingAttempts_LatestAttemptNotAfterLastAttempt {
            get {
                return ResourceManager.GetString("SendingAttempts_LatestAttemptNotAfterLastAttempt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All attempts must in chronological order.
        /// </summary>
        internal static string SendingAttempts_PreviousAttemptsNotInOrder {
            get {
                return ResourceManager.GetString("SendingAttempts_PreviousAttemptsNotInOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sms has already been delivered.
        /// </summary>
        internal static string SmsDeliveryRoot_AlreadyDelivered {
            get {
                return ResourceManager.GetString("SmsDeliveryRoot_AlreadyDelivered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sms has already been sent for delivery.
        /// </summary>
        internal static string SmsDeliveryRoot_AlreadySent {
            get {
                return ResourceManager.GetString("SmsDeliveryRoot_AlreadySent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sms message is missing a &apos;Body&apos;.
        /// </summary>
        internal static string SmsDeliveryRoot_MissingSmsBody {
            get {
                return ResourceManager.GetString("SmsDeliveryRoot_MissingSmsBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sms sending has not yet been attempted.
        /// </summary>
        internal static string SmsDeliveryRoot_NotAttempted {
            get {
                return ResourceManager.GetString("SmsDeliveryRoot_NotAttempted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sms has not yet been sent.
        /// </summary>
        internal static string SmsDeliveryRoot_NotSent {
            get {
                return ResourceManager.GetString("SmsDeliveryRoot_NotSent", resourceCulture);
            }
        }
    }
}
