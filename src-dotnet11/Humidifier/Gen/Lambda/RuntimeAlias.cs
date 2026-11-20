namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using RuntimeAliasTypes;

    public class RuntimeAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveRuntimeName, IHaveRuntimeVersion, IHaveLambdaRuntimeAliasTypesReleaseLifecycleReleaseLifecycle, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// RuntimeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-runtimename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuntimeName { get; set; }

        /// <summary>
        /// RuntimeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-runtimeversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuntimeVersion { get; set; }
        /// <summary>
        /// ReleaseLifecycle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtimealias.html#cfn-lambda-runtimealias-releaselifecycle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReleaseLifecycle
        /// </summary>
        public Union<Humidifier.Lambda.RuntimeAliasTypes.ReleaseLifecycle, BaseFunction>? ReleaseLifecycle { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuntimeAliasTypes
    {
        public class Compatibility : Humidifier.Base.BaseSubResource, IHaveStringListOfIntegrationModels, IHaveManagedInstances, IHaveStringListOfArchitectures
        {
            /// <summary>
            /// IntegrationModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-compatibility.html#cfn-lambda-runtimealias-compatibility-integrationmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IntegrationModels { get; set; }
            /// <summary>
            /// ManagedInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-compatibility.html#cfn-lambda-runtimealias-compatibility-managedinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedInstances { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-compatibility.html#cfn-lambda-runtimealias-compatibility-architectures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Architectures { get; set; }
        }

        public class ReleaseLifecycle : Humidifier.Base.BaseSubResource, IHaveFunctionCreateBlockDate, IHaveReleaseState, IHaveDeprecationDate, IHaveFunctionUpdateBlockDate
        {
            /// <summary>
            /// FunctionCreateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-functioncreateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionCreateBlockDate { get; set; }
            /// <summary>
            /// ReleaseState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-releasestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReleaseState { get; set; }
            /// <summary>
            /// DeprecationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-deprecationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeprecationDate { get; set; }
            /// <summary>
            /// FunctionUpdateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtimealias-releaselifecycle.html#cfn-lambda-runtimealias-releaselifecycle-functionupdateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionUpdateBlockDate { get; set; }
        }
    }
}