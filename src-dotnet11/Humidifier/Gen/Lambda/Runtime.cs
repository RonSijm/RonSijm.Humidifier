namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using RuntimeTypes;

    public class Runtime : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLicenseInfo, IHaveDescription, IHaveLambdaRuntimeTypesReleaseLifecycleReleaseLifecycle, IHaveName
    {
        public class Attributes
        {
            public static string LastModified =  "LastModified" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string Created =  "Created" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.Runtime; }
        /// <summary>
        /// LicenseInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-licenseinfo
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LicenseInfo { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ReleaseLifecycle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-releaselifecycle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReleaseLifecycle
        /// </summary>
        public Union<Humidifier.Lambda.RuntimeTypes.ReleaseLifecycle, BaseFunction>? ReleaseLifecycle { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuntimeTypes
    {
        public class ReleaseLifecycle : Humidifier.Base.BaseSubResource, IHaveFunctionCreateBlockDate, IHaveReleaseState, IHaveDeprecationDate, IHaveFunctionUpdateBlockDate
        {
            /// <summary>
            /// FunctionCreateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-functioncreateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionCreateBlockDate { get; set; }
            /// <summary>
            /// ReleaseState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-releasestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReleaseState { get; set; }
            /// <summary>
            /// DeprecationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-deprecationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeprecationDate { get; set; }
            /// <summary>
            /// FunctionUpdateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-functionupdateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionUpdateBlockDate { get; set; }
        }
    }
}