namespace Humidifier.MSK
{
    using global::System.Collections.Generic;
    using ConfigurationTypes;

    public class Configuration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveMSKConfigurationTypesLatestRevisionLatestRevision, IHaveServerProperties, IHaveStringListOfKafkaVersionsList, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MSK.Configuration; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-configuration.html#cfn-msk-configuration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// LatestRevision
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-configuration.html#cfn-msk-configuration-latestrevision
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LatestRevision
        /// </summary>
        public Union<Humidifier.MSK.ConfigurationTypes.LatestRevision, BaseFunction>? LatestRevision { get; set; }

        /// <summary>
        /// ServerProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-configuration.html#cfn-msk-configuration-serverproperties
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServerProperties { get; set; }
        /// <summary>
        /// KafkaVersionsList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-configuration.html#cfn-msk-configuration-kafkaversionslist
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? KafkaVersionsList { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationTypes
    {
        public class LatestRevision : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveRevision_Integer, IHaveCreationTime
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-configuration-latestrevision.html#cfn-msk-configuration-latestrevision-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-configuration-latestrevision.html#cfn-msk-configuration-latestrevision-revision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Revision { get; set; }
            /// <summary>
            /// CreationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-configuration-latestrevision.html#cfn-msk-configuration-latestrevision-creationtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreationTime { get; set; }
        }
    }
}