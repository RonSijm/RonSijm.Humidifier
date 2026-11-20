namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using RuntimeAliasTypes;

    public class RuntimeAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveRuntimeVersion
    {
        public class Attributes
        {
            public static string LastModified =  "LastModified" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string Compatibility =  "Compatibility" ;
            public static string RuntimeVersionArn =  "RuntimeVersionArn" ;
            public static string Created =  "Created" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.RuntimeAlias; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// RuntimeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-runtimename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuntimeName { get; set; }

        /// <summary>
        /// RuntimeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-runtimeversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuntimeVersion { get; set; }
        /// <summary>
        /// ReleaseLifecycle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-releaselifecycle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReleaseLifecycle
        /// </summary>
        public Humidifier.Lambda.RuntimeAliasTypes.ReleaseLifecycle ReleaseLifecycle { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuntimeAliasTypes
    {
        public class Compatibility : Humidifier.Base.BaseSubResource, IHaveArchitectures
        {
            /// <summary>
            /// IntegrationModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-compatibility.html#cfn-lambda-runtimealias-compatibility-integrationmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IntegrationModels { get; set; }
            /// <summary>
            /// ManagedInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-compatibility.html#cfn-lambda-runtimealias-compatibility-managedinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagedInstances { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-compatibility.html#cfn-lambda-runtimealias-compatibility-architectures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Architectures { get; set; }
        }

        public class ReleaseLifecycle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunctionCreateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-functioncreateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionCreateBlockDate { get; set; }
            /// <summary>
            /// ReleaseState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-releasestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReleaseState { get; set; }
            /// <summary>
            /// DeprecationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-deprecationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeprecationDate { get; set; }
            /// <summary>
            /// FunctionUpdateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-functionupdateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionUpdateBlockDate { get; set; }
        }
    }
}