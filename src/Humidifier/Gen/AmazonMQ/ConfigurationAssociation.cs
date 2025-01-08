namespace Humidifier.AmazonMQ
{
    using System.Collections.Generic;
    using ConfigurationAssociationTypes;

    public class ConfigurationAssociation : Humidifier.Base.BaseResource, IHaveBroker
    {
        public override string AWSTypeName { get => AWS.AmazonMQ.ConfigurationAssociation; }

        /// <summary>
        /// Broker
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html#cfn-amazonmq-configurationassociation-broker
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Broker { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html#cfn-amazonmq-configurationassociation-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConfigurationId
        /// </summary>
        [Required]
        public Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId Configuration { get; set; }
    }

    namespace ConfigurationAssociationTypes
    {
        public class ConfigurationId : Humidifier.Base.BaseSubResource, IHaveId, IHaveRevision
        {
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-configurationassociation-configurationid.html#cfn-amazonmq-configurationassociation-configurationid-revision
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Revision { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-configurationassociation-configurationid.html#cfn-amazonmq-configurationassociation-configurationid-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }
    }
}