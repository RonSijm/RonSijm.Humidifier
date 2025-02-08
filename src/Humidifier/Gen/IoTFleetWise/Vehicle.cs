namespace Humidifier.IoTFleetWise
{
    using System.Collections.Generic;
    using VehicleTypes;

    public class Vehicle : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveModelManifestArn
    {
        public class Attributes
        {
            public static string LastModificationTime =  "LastModificationTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTFleetWise.Vehicle; }
        /// <summary>
        /// AssociationBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-associationbehavior
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AssociationBehavior { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Attributes_ { get; set; }

        /// <summary>
        /// DecoderManifestArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-decodermanifestarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DecoderManifestArn { get; set; }
        /// <summary>
        /// StateTemplates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-statetemplates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StateTemplateAssociation
        /// </summary>
        public List<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation> StateTemplates { get; set; }

        /// <summary>
        /// ModelManifestArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-modelmanifestarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ModelManifestArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace VehicleTypes
    {
        public class PeriodicStateTemplateUpdateStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StateTemplateUpdateRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-periodicstatetemplateupdatestrategy.html#cfn-iotfleetwise-vehicle-periodicstatetemplateupdatestrategy-statetemplateupdaterate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TimePeriod
            /// </summary>
            public Humidifier.IoTFleetWise.VehicleTypes.TimePeriod StateTemplateUpdateRate { get; set; }
        }

        public class StateTemplateAssociation : Humidifier.Base.BaseSubResource, IHaveIdentifier
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateassociation.html#cfn-iotfleetwise-vehicle-statetemplateassociation-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
            /// <summary>
            /// StateTemplateUpdateStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateassociation.html#cfn-iotfleetwise-vehicle-statetemplateassociation-statetemplateupdatestrategy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StateTemplateUpdateStrategy
            /// </summary>
            public Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy StateTemplateUpdateStrategy { get; set; }
        }

        public class StateTemplateUpdateStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OnChange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateupdatestrategy.html#cfn-iotfleetwise-vehicle-statetemplateupdatestrategy-onchange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OnChange { get; set; }
            /// <summary>
            /// Periodic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateupdatestrategy.html#cfn-iotfleetwise-vehicle-statetemplateupdatestrategy-periodic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodicStateTemplateUpdateStrategy
            /// </summary>
            public Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy Periodic { get; set; }
        }

        public class TimePeriod : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-timeperiod.html#cfn-iotfleetwise-vehicle-timeperiod-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-timeperiod.html#cfn-iotfleetwise-vehicle-timeperiod-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }
    }
}