﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.Backend.ServiceContracts.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.Backend.ServiceContracts.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The backend configuration file is not present. Please check for existence or repair your installation..
        /// </summary>
        internal static string BackendConfigFileNotPresent {
            get {
                return ResourceManager.GetString("BackendConfigFileNotPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backend configuration successfully loaded..
        /// </summary>
        internal static string BackendConfigurationSuccessfullyLoaded {
            get {
                return ResourceManager.GetString("BackendConfigurationSuccessfullyLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;configuration&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;xs:element maxOccurs=&quot;unbounded&quot; name=&quot;service&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:attribute name=&quot;contract&quot; type=&quot;xs:string&quot; use=&quot;required&quot; /&gt;
        ///            &lt;xs:attribute name=&quot;service&quot; type=&quot;xs:string&quot; use=&quot;required&quot; /&gt;
        ///            &lt;xs:attribute n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BackendServiceLocationSchema {
            get {
                return ResourceManager.GetString("BackendServiceLocationSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Malformed connection string encountered!.
        /// </summary>
        internal static string EFHelper_ConnectionStringsMalformed {
            get {
                return ResourceManager.GetString("EFHelper_ConnectionStringsMalformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection strings found in the contained resource file!.
        /// </summary>
        internal static string EFHelper_NoConnectionStrings {
            get {
                return ResourceManager.GetString("EFHelper_NoConnectionStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource with name &apos;{0}&apos; was not found in assembly &apos;{1}&apos;! Please make sure that this file exists and its Build Action is set to &apos;Embedded Resource&apos;!.
        /// </summary>
        internal static string EFHelper_ResourceNotFound {
            get {
                return ResourceManager.GetString("EFHelper_ResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not assemble the address because the specified binding is not supported!.
        /// </summary>
        internal static string GetEndpointAddressInvalidBinding {
            get {
                return ResourceManager.GetString("GetEndpointAddressInvalidBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is no supported binding!.
        /// </summary>
        internal static string InvalidSupportedBindingValue {
            get {
                return ResourceManager.GetString("InvalidSupportedBindingValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was no attribute found for service contract type &apos;{0}&apos;. Cannot retrieve binding..
        /// </summary>
        internal static string NoAttributeForServiceContractTypeFound {
            get {
                return ResourceManager.GetString("NoAttributeForServiceContractTypeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only interface types are allowed for this parameter!.
        /// </summary>
        internal static string RegisterAlarmWorkflowServiceAttributeContractTypeAllowsOnlyInterfaces {
            get {
                return ResourceManager.GetString("RegisterAlarmWorkflowServiceAttributeContractTypeAllowsOnlyInterfaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only concrete classes (also no abstract classes) are allowed for this parameter!.
        /// </summary>
        internal static string RegisterAlarmWorkflowServiceAttributeServiceTypeAllowsOnlyClasses {
            get {
                return ResourceManager.GetString("RegisterAlarmWorkflowServiceAttributeServiceTypeAllowsOnlyClasses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided instance is not a service object. Please only dispose services created by GetServiceInstance&lt;T&gt;()!.
        /// </summary>
        internal static string ServiceFactoryInstanceIsNotAServiceObject {
            get {
                return ResourceManager.GetString("ServiceFactoryInstanceIsNotAServiceObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service interface name is malformed! It shall be named like: &apos;INameOfService&apos;!.
        /// </summary>
        internal static string ServiceFactoryInterfaceNameMalformed {
            get {
                return ResourceManager.GetString("ServiceFactoryInterfaceNameMalformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot work with concrete types. Please specify an interface!.
        /// </summary>
        internal static string ServiceFactoryInvalidType {
            get {
                return ResourceManager.GetString("ServiceFactoryInvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find service location file! Cannot start service!.
        /// </summary>
        internal static string ServiceLocationFileNotPresent {
            get {
                return ResourceManager.GetString("ServiceLocationFileNotPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service cannot be used. Maybe it is faulted!.
        /// </summary>
        internal static string WrappedService_GetInstanceException {
            get {
                return ResourceManager.GetString("WrappedService_GetInstanceException", resourceCulture);
            }
        }
    }
}
