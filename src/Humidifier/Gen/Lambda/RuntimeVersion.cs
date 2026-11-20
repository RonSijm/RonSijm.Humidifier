namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using RuntimeVersionTypes;

    public class RuntimeVersion : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveImageUri
    {
        public class Attributes
        {
            public static string LastModified =  "LastModified" ;
            public static string Platforms =  "Platforms" ;
            public static string ResolvedUri =  "ResolvedUri" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string Compatibility =  "Compatibility" ;
            public static string Created =  "Created" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.RuntimeVersion; }

        /// <summary>
        /// RuntimeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimeversion.html#cfn-lambda-runtimeversion-runtimename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuntimeName { get; set; }
        /// <summary>
        /// ImageUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimeversion.html#cfn-lambda-runtimeversion-imageuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageUri { get; set; }
        /// <summary>
        /// ReleaseNotes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimeversion.html#cfn-lambda-runtimeversion-releasenotes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReleaseNotes { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuntimeVersionTypes
    {
        public class Compatibility : Humidifier.Base.BaseSubResource, IHaveArchitectures
        {
            /// <summary>
            /// IntegrationModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-compatibility.html#cfn-lambda-runtimeversion-compatibility-integrationmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IntegrationModels { get; set; }
            /// <summary>
            /// ManagedInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-compatibility.html#cfn-lambda-runtimeversion-compatibility-managedinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagedInstances { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-compatibility.html#cfn-lambda-runtimeversion-compatibility-architectures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Architectures { get; set; }
        }

        public class Platform : Humidifier.Base.BaseSubResource, IHaveArchitecture
        {
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-platform.html#cfn-lambda-runtimeversion-platform-architecture
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Architecture { get; set; }
            /// <summary>
            /// Os
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-platform.html#cfn-lambda-runtimeversion-platform-os
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Os { get; set; }
            /// <summary>
            /// Digest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-platform.html#cfn-lambda-runtimeversion-platform-digest
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Digest { get; set; }
        }
    }
}