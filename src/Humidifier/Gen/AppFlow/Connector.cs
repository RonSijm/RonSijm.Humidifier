namespace Humidifier.AppFlow
{
    using System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveDescription
    {
        public class Attributes
        {
            public static string ConnectorArn =  "ConnectorArn" ;
        }

        public override string AWSTypeName { get => AWS.AppFlow.Connector; }
        /// <summary>
        /// ConnectorLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connector.html#cfn-appflow-connector-connectorlabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectorLabel { get; set; }

        /// <summary>
        /// ConnectorProvisioningType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connector.html#cfn-appflow-connector-connectorprovisioningtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectorProvisioningType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connector.html#cfn-appflow-connector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ConnectorProvisioningConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connector.html#cfn-appflow-connector-connectorprovisioningconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConnectorProvisioningConfig
        /// </summary>
        [Required]
        public Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig ConnectorProvisioningConfig { get; set; }
    }

    namespace ConnectorTypes
    {
        public class ConnectorProvisioningConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connector-connectorprovisioningconfig.html#cfn-appflow-connector-connectorprovisioningconfig-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaConnectorProvisioningConfig
            /// </summary>
            public Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig Lambda { get; set; }
        }

        public class LambdaConnectorProvisioningConfig : Humidifier.Base.BaseSubResource, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connector-lambdaconnectorprovisioningconfig.html#cfn-appflow-connector-lambdaconnectorprovisioningconfig-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
        }
    }
}