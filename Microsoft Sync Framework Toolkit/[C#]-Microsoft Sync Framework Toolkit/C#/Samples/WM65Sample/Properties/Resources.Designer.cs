﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartDeviceProject1.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SmartDeviceProject1.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to -- 6/3/2010 9:43 AM
        ///-- Database information:
        ///-- locale identifier: 1033
        ///-- encryption mode: 
        ///-- case sensitive: False
        ///
        ///CREATE TABLE [Item] ([ID] uniqueidentifier NOT NULL   
        ///, [ListID] uniqueidentifier NOT NULL   
        ///, [UserID] uniqueidentifier NOT NULL   
        ///, [Name] nvarchar(50) NOT NULL  
        ///, [Description] nvarchar(250) NULL  
        ///, [Priority] int NULL   
        ///, [Status] int NULL   
        ///, [StartDate] datetime NULL   
        ///, [EndDate] datetime NULL   
        ///);
        ///GO
        ///CREATE TABLE [List] ([ID] uniqueidentifier NOT NULL DEFAU [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ListDb {
            get {
                return ResourceManager.GetString("ListDb", resourceCulture);
            }
        }
    }
}