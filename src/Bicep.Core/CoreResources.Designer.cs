﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CoreResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.Core.CoreResources", typeof(CoreResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When setting an adminUserName property, don&apos;t use a literal value..
        /// </summary>
        public static string AdminUsernameShouldNotBeLiteralRuleDescription {
            get {
                return ResourceManager.GetString("AdminUsernameShouldNotBeLiteralRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom bicepconfig.json file found ({0})..
        /// </summary>
        public static string BicepConfigCustomSettingsFoundFormatMessage {
            get {
                return ResourceManager.GetString("BicepConfigCustomSettingsFoundFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No bicepconfig.json found for configuration override..
        /// </summary>
        public static string BicepConfigNoCustomSettingsMessage {
            get {
                return ResourceManager.GetString("BicepConfigNoCustomSettingsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment URLs should not be hardcoded. Use the environment() function to ensure compatibility across clouds..
        /// </summary>
        public static string EnvironmentUrlHardcodedRuleDescription {
            get {
                return ResourceManager.GetString("EnvironmentUrlHardcodedRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation instead of the concat function..
        /// </summary>
        public static string InterpolateNotConcatRuleDescription {
            get {
                return ResourceManager.GetString("InterpolateNotConcatRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Linter is disabled in settings file located at {0} .
        /// </summary>
        public static string LinterDisabledFormatMessage {
            get {
                return ResourceManager.GetString("LinterDisabledFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzer &apos;{0}&apos; encountered an unexpected exception. {1}.
        /// </summary>
        public static string LinterRuleExceptionMessageFormat {
            get {
                return ResourceManager.GetString("LinterRuleExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource location should be specified by a parameter with no default value or one that defaults to &apos;global&apos; or resourceGroup().location..
        /// </summary>
        public static string LocationSetByParameterRuleDescription {
            get {
                return ResourceManager.GetString("LocationSetByParameterRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter is declared but never used..
        /// </summary>
        public static string ParameterMustBeUsedRuleDescription {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; is declared but never used..
        /// </summary>
        public static string ParameterMustBeUsedRuleFixMessageFormat {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleFixMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secure parameters should not have hardcoded defaults (except for empty or newGuid())..
        /// </summary>
        public static string SecureParameterDefaultRuleDescription {
            get {
                return ResourceManager.GetString("SecureParameterDefaultRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary string interpolation..
        /// </summary>
        public static string SimplifyInterpolationRuleDescription {
            get {
                return ResourceManager.GetString("SimplifyInterpolationRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary dependsOn..
        /// </summary>
        public static string UnnecessaryDependsOnRuleDescription {
            get {
                return ResourceManager.GetString("UnnecessaryDependsOnRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable is declared but never used..
        /// </summary>
        public static string UnusedVariableRuleDescription {
            get {
                return ResourceManager.GetString("UnusedVariableRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable &quot;{0}&quot; is declared but never used..
        /// </summary>
        public static string UnusedVariableRuleFixMessageFormat {
            get {
                return ResourceManager.GetString("UnusedVariableRuleFixMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use recent API version..
        /// </summary>
        public static string UseRecentApiVersionRuleDescription {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use recent API version {0}.
        /// </summary>
        public static string UseRecentApiVersionRuleFixMessageFormat {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRuleFixMessageFormat", resourceCulture);
            }
        }
    }
}
