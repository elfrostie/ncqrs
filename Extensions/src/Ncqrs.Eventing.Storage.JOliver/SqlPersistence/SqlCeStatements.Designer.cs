﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ncqrs.Eventing.Storage.JOliver.SqlPersistence {
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
    internal class SqlCeStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlCeStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ncqrs.Eventing.Storage.JOliver.SqlPersistence.SqlCeStatements", typeof(SqlCeStatements).Assembly);
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
        ///   Looks up a localized string similar to SELECT TOP(1) SequentialId FROM PipelineState WHERE PipelineName = @PipelineName ORDER BY SequentialId DESC.
        /// </summary>
        internal static string GetLastProcessedCommit {
            get {
                return ResourceManager.GetString("GetLastProcessedCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE PipelineState(
        ///	CheckPointId int IDENTITY(1,1) NOT NULL,
        ///	PipelineName nvarchar(255) NOT NULL,
        ///	SequentialId bigint NULL,
        ///	CONSTRAINT PK_PipelineState PRIMARY KEY (CheckPointId));
        ///
        ///CREATE INDEX IX_PipelineSate_Name ON PipelineState	(PipelineName);
        ///
        ///CREATE TABLE CommitSequence(
        ///	SequentialId bigint IDENTITY(1,1) NOT NULL,
        ///	CommitId uniqueidentifier NOT NULL,
        /// CONSTRAINT PK_CommitSequence PRIMARY KEY (SequentialId));
        ///
        ///CREATE INDEX IX_Commits_CommitId ON Commits (CommitId);.
        /// </summary>
        internal static string Initialize {
            get {
                return ResourceManager.GetString("Initialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO PipelineState (PipelineName, SequentialId) 
        ///SELECT @PipelineName, SequentialId FROM CommitSequence WHERE CommitId = @CommitId.
        /// </summary>
        internal static string MarkLastProcessedCommit {
            get {
                return ResourceManager.GetString("MarkLastProcessedCommit", resourceCulture);
            }
        }
    }
}
