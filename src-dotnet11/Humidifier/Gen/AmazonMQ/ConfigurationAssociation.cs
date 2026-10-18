namespace Humidifier.AmazonMQ
{
    using global::System.Collections.Generic;
    using ConfigurationAssociationTypes;

    public class ConfigurationAssociation : Humidifier.Base.BaseResource, IHaveBroker, IHaveAmazonMQConfigurationAssociationTypesConfigurationIdConfiguration
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.AmazonMQ.ConfigurationAssociation; }

        /// <summary>
        /// Broker
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html#cfn-amazonmq-configurationassociation-broker
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Broker { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html#cfn-amazonmq-configurationassociation-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConfigurationId
        /// </summary>
        [Required]
        public Union<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId, BaseFunction>? Configuration { get; set; }
    }

    namespace ConfigurationAssociationTypes
    {
        public class ConfigurationId : Humidifier.Base.BaseSubResource, IHaveRevision_Integer, IHaveId
        {
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-configurationassociation-configurationid.html#cfn-amazonmq-configurationassociation-configurationid-revision
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Revision { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-configurationassociation-configurationid.html#cfn-amazonmq-configurationassociation-configurationid-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }
    }
}