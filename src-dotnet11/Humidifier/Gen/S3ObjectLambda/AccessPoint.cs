namespace Humidifier.S3ObjectLambda
{
    using global::System.Collections.Generic;
    using AccessPointTypes;

    public class AccessPoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveS3ObjectLambdaAccessPointTypesObjectLambdaConfigurationObjectLambdaConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string PublicAccessBlockConfiguration =  "PublicAccessBlockConfiguration" ;
            public static string Alias =  "Alias" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.S3ObjectLambda.AccessPoint; }

        /// <summary>
        /// ObjectLambdaConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3objectlambda-accesspoint.html#cfn-s3objectlambda-accesspoint-objectlambdaconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ObjectLambdaConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration, BaseFunction>? ObjectLambdaConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AccessPointTypes
    {
        public class Alias : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveValue
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-alias.html#cfn-s3objectlambda-accesspoint-alias-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-alias.html#cfn-s3objectlambda-accesspoint-alias-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class AwsLambda : Humidifier.Base.BaseSubResource, IHaveFunctionArn, IHaveFunctionPayload
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-awslambda.html#cfn-s3objectlambda-accesspoint-awslambda-functionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// FunctionPayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-awslambda.html#cfn-s3objectlambda-accesspoint-awslambda-functionpayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionPayload { get; set; }
        }

        public class ContentTransformation : Humidifier.Base.BaseSubResource, IHaveS3ObjectLambdaAccessPointTypesAwsLambdaAwsLambda
        {
            /// <summary>
            /// AwsLambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-contenttransformation.html#cfn-s3objectlambda-accesspoint-contenttransformation-awslambda
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AwsLambda
            /// </summary>
            public Union<Humidifier.S3ObjectLambda.AccessPointTypes.AwsLambda, BaseFunction>? AwsLambda { get; set; }
        }

        public class ObjectLambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveSupportingAccessPoint, IHaveListOfS3ObjectLambdaAccessPointTypesTransformationConfigurationTransformationConfigurations, IHaveStringListOfAllowedFeatures, IHaveCloudWatchMetricsEnabled_Boolean
        {
            /// <summary>
            /// SupportingAccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-objectlambdaconfiguration.html#cfn-s3objectlambda-accesspoint-objectlambdaconfiguration-supportingaccesspoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SupportingAccessPoint { get; set; }
            /// <summary>
            /// TransformationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-objectlambdaconfiguration.html#cfn-s3objectlambda-accesspoint-objectlambdaconfiguration-transformationconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TransformationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3ObjectLambda.AccessPointTypes.TransformationConfiguration>, IReadOnlyList<Union<Humidifier.S3ObjectLambda.AccessPointTypes.TransformationConfiguration, BaseFunction>>, BaseFunction>? TransformationConfigurations { get; set; }
            /// <summary>
            /// AllowedFeatures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-objectlambdaconfiguration.html#cfn-s3objectlambda-accesspoint-objectlambdaconfiguration-allowedfeatures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedFeatures { get; set; }
            /// <summary>
            /// CloudWatchMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-objectlambdaconfiguration.html#cfn-s3objectlambda-accesspoint-objectlambdaconfiguration-cloudwatchmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudWatchMetricsEnabled { get; set; }
        }

        public class PublicAccessBlockConfiguration : Humidifier.Base.BaseSubResource, IHaveRestrictPublicBuckets_Boolean, IHaveBlockPublicPolicy_Boolean, IHaveBlockPublicAcls_Boolean, IHaveIgnorePublicAcls_Boolean
        {
            /// <summary>
            /// RestrictPublicBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-publicaccessblockconfiguration.html#cfn-s3objectlambda-accesspoint-publicaccessblockconfiguration-restrictpublicbuckets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RestrictPublicBuckets { get; set; }
            /// <summary>
            /// BlockPublicPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-publicaccessblockconfiguration.html#cfn-s3objectlambda-accesspoint-publicaccessblockconfiguration-blockpublicpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicPolicy { get; set; }
            /// <summary>
            /// BlockPublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-publicaccessblockconfiguration.html#cfn-s3objectlambda-accesspoint-publicaccessblockconfiguration-blockpublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicAcls { get; set; }
            /// <summary>
            /// IgnorePublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-publicaccessblockconfiguration.html#cfn-s3objectlambda-accesspoint-publicaccessblockconfiguration-ignorepublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnorePublicAcls { get; set; }
        }

        public class TransformationConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveS3ObjectLambdaAccessPointTypesContentTransformationContentTransformation
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-transformationconfiguration.html#cfn-s3objectlambda-accesspoint-transformationconfiguration-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// ContentTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-transformationconfiguration.html#cfn-s3objectlambda-accesspoint-transformationconfiguration-contenttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ContentTransformation
            /// </summary>
            public Union<Humidifier.S3ObjectLambda.AccessPointTypes.ContentTransformation, BaseFunction>? ContentTransformation { get; set; }
        }
    }
}