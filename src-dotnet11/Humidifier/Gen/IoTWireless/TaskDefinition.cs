namespace Humidifier.IoTWireless
{
    using global::System.Collections.Generic;
    using TaskDefinitionTypes;

    public class TaskDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAutoCreateTasks_Boolean, IHaveIoTWirelessTaskDefinitionTypesLoRaWANUpdateGatewayTaskEntryLoRaWANUpdateGatewayTaskEntry, IHaveIoTWirelessTaskDefinitionTypesUpdateWirelessGatewayTaskCreateUpdate, IHaveTaskDefinitionType, IHaveName
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
        public Union<bool, BaseFunction>? AutoCreateTasks { get; set; }
        /// <summary>
        /// LoRaWANUpdateGatewayTaskEntry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskentry
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoRaWANUpdateGatewayTaskEntry
        /// </summary>
        public Union<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry, BaseFunction>? LoRaWANUpdateGatewayTaskEntry { get; set; }
        /// <summary>
        /// Update
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-update
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpdateWirelessGatewayTaskCreate
        /// </summary>
        public Union<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate, BaseFunction>? Update { get; set; }
        /// <summary>
        /// TaskDefinitionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-taskdefinitiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TaskDefinitionType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html#cfn-iotwireless-taskdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TaskDefinitionTypes
    {
        public class LoRaWANGatewayVersion : Humidifier.Base.BaseSubResource, IHaveStation, IHaveModel, IHavePackageVersion
        {
            /// <summary>
            /// Station
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html#cfn-iotwireless-taskdefinition-lorawangatewayversion-station
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Station { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html#cfn-iotwireless-taskdefinition-lorawangatewayversion-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// PackageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html#cfn-iotwireless-taskdefinition-lorawangatewayversion-packageversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PackageVersion { get; set; }
        }

        public class LoRaWANUpdateGatewayTaskCreate : Humidifier.Base.BaseSubResource, IHaveUpdateSignature, IHaveSigKeyCrc_Long, IHaveIoTWirelessTaskDefinitionTypesLoRaWANGatewayVersionUpdateVersion, IHaveIoTWirelessTaskDefinitionTypesLoRaWANGatewayVersionCurrentVersion
        {
            /// <summary>
            /// UpdateSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-updatesignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSignature { get; set; }
            /// <summary>
            /// SigKeyCrc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-sigkeycrc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? SigKeyCrc { get; set; }
            /// <summary>
            /// UpdateVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-updateversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Union<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion, BaseFunction>? UpdateVersion { get; set; }
            /// <summary>
            /// CurrentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate-currentversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Union<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion, BaseFunction>? CurrentVersion { get; set; }
        }

        public class LoRaWANUpdateGatewayTaskEntry : Humidifier.Base.BaseSubResource, IHaveIoTWirelessTaskDefinitionTypesLoRaWANGatewayVersionUpdateVersion, IHaveIoTWirelessTaskDefinitionTypesLoRaWANGatewayVersionCurrentVersion
        {
            /// <summary>
            /// UpdateVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskentry.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskentry-updateversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Union<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion, BaseFunction>? UpdateVersion { get; set; }
            /// <summary>
            /// CurrentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskentry.html#cfn-iotwireless-taskdefinition-lorawanupdategatewaytaskentry-currentversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANGatewayVersion
            /// </summary>
            public Union<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion, BaseFunction>? CurrentVersion { get; set; }
        }

        public class UpdateWirelessGatewayTaskCreate : Humidifier.Base.BaseSubResource, IHaveIoTWirelessTaskDefinitionTypesLoRaWANUpdateGatewayTaskCreateLoRaWAN, IHaveUpdateDataSource, IHaveUpdateDataRole
        {
            /// <summary>
            /// LoRaWAN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html#cfn-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate-lorawan
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoRaWANUpdateGatewayTaskCreate
            /// </summary>
            public Union<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate, BaseFunction>? LoRaWAN { get; set; }
            /// <summary>
            /// UpdateDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html#cfn-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate-updatedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDataSource { get; set; }
            /// <summary>
            /// UpdateDataRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html#cfn-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate-updatedatarole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDataRole { get; set; }
        }
    }
}