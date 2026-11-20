namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using RuntimeVersionTypes;

    public class RuntimeVersion : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveRuntimeName, IHaveImageUri, IHaveReleaseNotes, IHaveName
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
        public Union<string, BaseFunction>? RuntimeName { get; set; }
        /// <summary>
        /// ImageUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimeversion.html#cfn-lambda-runtimeversion-imageuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageUri { get; set; }
        /// <summary>
        /// ReleaseNotes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimeversion.html#cfn-lambda-runtimeversion-releasenotes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReleaseNotes { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuntimeVersionTypes
    {
        public class Compatibility : Humidifier.Base.BaseSubResource, IHaveStringListOfIntegrationModels, IHaveManagedInstances, IHaveStringListOfArchitectures
        {
            /// <summary>
            /// IntegrationModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-compatibility.html#cfn-lambda-runtimeversion-compatibility-integrationmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IntegrationModels { get; set; }
            /// <summary>
            /// ManagedInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-compatibility.html#cfn-lambda-runtimeversion-compatibility-managedinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedInstances { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-compatibility.html#cfn-lambda-runtimeversion-compatibility-architectures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Architectures { get; set; }
        }

        public class Platform : Humidifier.Base.BaseSubResource, IHaveArchitecture, IHaveOs, IHaveDigest
        {
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-platform.html#cfn-lambda-runtimeversion-platform-architecture
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Architecture { get; set; }
            /// <summary>
            /// Os
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-platform.html#cfn-lambda-runtimeversion-platform-os
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Os { get; set; }
            /// <summary>
            /// Digest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimeversion-platform.html#cfn-lambda-runtimeversion-platform-digest
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Digest { get; set; }
        }
    }
}