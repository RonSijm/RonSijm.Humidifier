namespace Humidifier.IoTWireless
{
    using System.Collections.Generic;
    using TaskDefinitionTypes;

    public class TaskDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.TaskDefinition; }

        /// <summary>
        /// AutoCreateTasks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-autocreatetasks
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic AutoCreateTasks { get; set; }
        /// <summary>
        /// LoRaWANUpdateGatewayTaskEntry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskentry
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoRaWANUpdateGatewayTaskEntry
        /// </summary>
        public Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry LoRaWANUpdateGatewayTaskEntry { get; set; }
        /// <summary>
        /// Update
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-update
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpdateWirelessGatewayTaskCreate
        /// </summary>
        public Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate Update { get; set; }
        /// <summary>
        /// TaskDefinitionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-taskdefinitiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskDefinitionType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TaskDefinitionTypes
    {
        public class LoRaWANGatewayVersion : Humidifier.Base.BaseSubResource, IHaveModel
        {
            /// <summary>
            /// Station
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html#cfn-iotwireless-taskdefinition-lorawangatewayversion-station
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Station { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html#cfn-iotwireless-taskdefinition-lorawangatewayversion-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Model { get; set; }
            /// <summary>
            /// PackageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html#cfn-iotwireless-taskdefinition-lorawangatewayversion-packageversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PackageVersion { get; set; }
        }

        public class LoRaWANUpdateGatewayTaskCreate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UpdateSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-updatesignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSignature { get; set; }
            /// <summary>
            /// SigKeyCrc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-sigkeycrc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SigKeyCrc { get; set; }
            /// <summary>
            /// UpdateVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-updateversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion UpdateVersion { get; set; }
            /// <summary>
            /// CurrentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-currentversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion CurrentVersion { get; set; }
        }

        public class LoRaWANUpdateGatewayTaskEntry : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UpdateVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskentry.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskentry-updateversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion UpdateVersion { get; set; }
            /// <summary>
            /// CurrentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskentry.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskentry-currentversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion CurrentVersion { get; set; }
        }

        public class UpdateWirelessGatewayTaskCreate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoRaWAN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html#cfn-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate-lorawan
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANUpdateGatewayTaskCreate
            /// </summary>
            public Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate LoRaWAN { get; set; }
            /// <summary>
            /// UpdateDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html#cfn-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate-updatedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDataSource { get; set; }
            /// <summary>
            /// UpdateDataRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html#cfn-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate-updatedatarole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDataRole { get; set; }
        }
    }
}