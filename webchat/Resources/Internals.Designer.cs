﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
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
    public class Internals {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Internals() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("webchat.Resources.Internals", typeof(Internals).Assembly);
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
        ///   Looks up a localized string similar to dd/MM/yyyy HH:mm:ss.
        /// </summary>
        public static string DateTimeFormat {
            get {
                return ResourceManager.GetString("DateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to trace.log.
        /// </summary>
        public static string LogFile {
            get {
                return ResourceManager.GetString("LogFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to message.
        /// </summary>
        public static string MessagesEventChannel {
            get {
                return ResourceManager.GetString("MessagesEventChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ping.
        /// </summary>
        public static string PingEventChannel {
            get {
                return ResourceManager.GetString("PingEventChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to rooms.
        /// </summary>
        public static string RoomsEventChannel {
            get {
                return ResourceManager.GetString("RoomsEventChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to users.
        /// </summary>
        public static string UsersEventChannel {
            get {
                return ResourceManager.GetString("UsersEventChannel", resourceCulture);
            }
        }
    }
}
