namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSsmInstanceID, IHaveMGNConnectorTypesConnectorSsmCommandConfigSsmCommandConfig, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string ConnectorID =  "ConnectorID" ;
        }

        public override string AWSTypeName { get => AWS.MGN.Connector; }

        /// <summary>
        /// SsmInstanceID
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-connector.html#cfn-mgn-connector-ssminstanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SsmInstanceID { get; set; }
        /// <summary>
        /// SsmCommandConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-connector.html#cfn-mgn-connector-ssmcommandconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectorSsmCommandConfig
        /// </summary>
        public Union<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig, BaseFunction>? SsmCommandConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-connector.html#cfn-mgn-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConnectorTypes
    {
        public class ConnectorSsmCommandConfig : Humidifier.Base.BaseSubResource, IHaveCloudWatchOutputEnabled_Boolean, IHaveCloudWatchLogGroupName, IHaveS3OutputEnabled_Boolean, IHaveOutputS3BucketName
        {
            /// <summary>
            /// CloudWatchOutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-connector-connectorssmcommandconfig.html#cfn-mgn-connector-connectorssmcommandconfig-cloudwatchoutputenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudWatchOutputEnabled { get; set; }
            /// <summary>
            /// CloudWatchLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-connector-connectorssmcommandconfig.html#cfn-mgn-connector-connectorssmcommandconfig-cloudwatchloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogGroupName { get; set; }
            /// <summary>
            /// S3OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-connector-connectorssmcommandconfig.html#cfn-mgn-connector-connectorssmcommandconfig-s3outputenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? S3OutputEnabled { get; set; }
            /// <summary>
            /// OutputS3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-connector-connectorssmcommandconfig.html#cfn-mgn-connector-connectorssmcommandconfig-outputs3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3BucketName { get; set; }
        }
    }
}