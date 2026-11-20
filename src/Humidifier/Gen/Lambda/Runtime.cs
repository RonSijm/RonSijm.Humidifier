namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using RuntimeTypes;

    public class Runtime : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic LicenseInfo { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ReleaseLifecycle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-releaselifecycle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReleaseLifecycle
        /// </summary>
        public Humidifier.Lambda.RuntimeTypes.ReleaseLifecycle ReleaseLifecycle { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-runtime.html#cfn-lambda-runtime-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuntimeTypes
    {
        public class ReleaseLifecycle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunctionCreateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-functioncreateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionCreateBlockDate { get; set; }
            /// <summary>
            /// ReleaseState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-releasestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReleaseState { get; set; }
            /// <summary>
            /// DeprecationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-deprecationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeprecationDate { get; set; }
            /// <summary>
            /// FunctionUpdateBlockDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-runtime-releaselifecycle.html#cfn-lambda-runtime-releaselifecycle-functionupdateblockdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionUpdateBlockDate { get; set; }
        }
    }
}