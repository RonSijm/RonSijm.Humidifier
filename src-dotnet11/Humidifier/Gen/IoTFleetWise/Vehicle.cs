namespace Humidifier.IoTFleetWise
{
    using global::System.Collections.Generic;
    using VehicleTypes;

    public class Vehicle : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAssociationBehavior, IHaveStringDictionaryOfAttributes_, IHaveDecoderManifestArn, IHaveListOfIoTFleetWiseVehicleTypesStateTemplateAssociationStateTemplates, IHaveModelManifestArn, IHaveName
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
        public Union<string, BaseFunction>? AssociationBehavior { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }

        /// <summary>
        /// DecoderManifestArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-decodermanifestarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DecoderManifestArn { get; set; }
        /// <summary>
        /// StateTemplates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-statetemplates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StateTemplateAssociation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation>, IReadOnlyList<Union<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateAssociation, BaseFunction>>, BaseFunction>? StateTemplates { get; set; }

        /// <summary>
        /// ModelManifestArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-modelmanifestarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelManifestArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-vehicle.html#cfn-iotfleetwise-vehicle-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace VehicleTypes
    {
        public class PeriodicStateTemplateUpdateStrategy : Humidifier.Base.BaseSubResource, IHaveIoTFleetWiseVehicleTypesTimePeriodStateTemplateUpdateRate
        {
            /// <summary>
            /// StateTemplateUpdateRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-periodicstatetemplateupdatestrategy.html#cfn-iotfleetwise-vehicle-periodicstatetemplateupdatestrategy-statetemplateupdaterate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TimePeriod
            /// </summary>
            public Union<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod, BaseFunction>? StateTemplateUpdateRate { get; set; }
        }

        public class StateTemplateAssociation : Humidifier.Base.BaseSubResource, IHaveIdentifier, IHaveIoTFleetWiseVehicleTypesStateTemplateUpdateStrategyStateTemplateUpdateStrategy
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateassociation.html#cfn-iotfleetwise-vehicle-statetemplateassociation-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// StateTemplateUpdateStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateassociation.html#cfn-iotfleetwise-vehicle-statetemplateassociation-statetemplateupdatestrategy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StateTemplateUpdateStrategy
            /// </summary>
            public Union<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy, BaseFunction>? StateTemplateUpdateStrategy { get; set; }
        }

        public class StateTemplateUpdateStrategy : Humidifier.Base.BaseSubResource, IHaveOnChange_Json, IHaveIoTFleetWiseVehicleTypesPeriodicStateTemplateUpdateStrategyPeriodic
        {
            /// <summary>
            /// OnChange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateupdatestrategy.html#cfn-iotfleetwise-vehicle-statetemplateupdatestrategy-onchange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? OnChange { get; set; }
            /// <summary>
            /// Periodic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-statetemplateupdatestrategy.html#cfn-iotfleetwise-vehicle-statetemplateupdatestrategy-periodic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodicStateTemplateUpdateStrategy
            /// </summary>
            public Union<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy, BaseFunction>? Periodic { get; set; }
        }

        public class TimePeriod : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-timeperiod.html#cfn-iotfleetwise-vehicle-timeperiod-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-vehicle-timeperiod.html#cfn-iotfleetwise-vehicle-timeperiod-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }
    }
}