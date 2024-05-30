﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Persistence.Azure {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Infrastructure.Persistence.Azure.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The message is too large to send in a batch for an Azure Service Bus.
        /// </summary>
        internal static string AzureServiceBusStore_MessageTooLarge {
            get {
                return ResourceManager.GetString("AzureServiceBusStore_MessageTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message cannot be empty.
        /// </summary>
        internal static string AzureServiceBusStore_MissingSentMessage {
            get {
                return ResourceManager.GetString("AzureServiceBusStore_MissingSentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SubscriptionName cannot be empty.
        /// </summary>
        internal static string AzureServiceBusStore_MissingSubscriptionName {
            get {
                return ResourceManager.GetString("AzureServiceBusStore_MissingSubscriptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TopicName cannot be empty.
        /// </summary>
        internal static string AzureServiceBusStore_MissingTopicName {
            get {
                return ResourceManager.GetString("AzureServiceBusStore_MissingTopicName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message cannot be empty.
        /// </summary>
        internal static string AzureStorageAccountQueueStore_MissingMessage {
            get {
                return ResourceManager.GetString("AzureStorageAccountQueueStore_MissingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QueueName cannot be empty.
        /// </summary>
        internal static string AzureStorageAccountQueueStore_MissingQueueName {
            get {
                return ResourceManager.GetString("AzureStorageAccountQueueStore_MissingQueueName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure Service Bus subscription name: &apos;{0}&apos; contains illegal characters or is not the correct length.
        /// </summary>
        internal static string ValidationExtensions_InvalidMessageBusSubscriptionName {
            get {
                return ResourceManager.GetString("ValidationExtensions_InvalidMessageBusSubscriptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure Service Bus topic name: &apos;{0}&apos; contains illegal characters or is not the correct length.
        /// </summary>
        internal static string ValidationExtensions_InvalidMessageBusTopicName {
            get {
                return ResourceManager.GetString("ValidationExtensions_InvalidMessageBusTopicName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure Storage Table/Blob/Queue name: &apos;{0}&apos; contains illegal characters or is not the correct length.
        /// </summary>
        internal static string ValidationExtensions_InvalidStorageAccountResourceName {
            get {
                return ResourceManager.GetString("ValidationExtensions_InvalidStorageAccountResourceName", resourceCulture);
            }
        }
    }
}
