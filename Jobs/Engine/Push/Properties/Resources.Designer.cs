﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.Job.PushJob.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.Job.PushJob.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to While executing the notifications for &apos;Notify my Android&apos; an unexpected error occured: {0}..
        /// </summary>
        internal static string ErrorNMA {
            get {
                return ResourceManager.GetString("ErrorNMA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to While executing the notifications for Prowl an unexpected error occured: {0}..
        /// </summary>
        internal static string ErrorProwl {
            get {
                return ResourceManager.GetString("ErrorProwl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Versendet Push-Nachrichten mittels verschiedener Anbieter..
        /// </summary>
        internal static string ExportJobDescription {
            get {
                return ResourceManager.GetString("ExportJobDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Push-Versand.
        /// </summary>
        internal static string ExportJobDisplayName {
            get {
                return ResourceManager.GetString("ExportJobDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sent &apos;Notify my Android&apos; notifications. Server response was: {0}.
        /// </summary>
        internal static string NMA {
            get {
                return ResourceManager.GetString("NMA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sent Prowl notifications. Server response was: {0}.
        /// </summary>
        internal static string Prowl {
            get {
                return ResourceManager.GetString("Prowl", resourceCulture);
            }
        }
    }
}
