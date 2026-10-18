namespace Humidifier.ControlTower
{
    using global::System.Collections.Generic;
    using EnabledControlTypes;

    public class EnabledControl : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfControlTowerEnabledControlTypesEnabledControlParameterParameters, IHaveControlIdentifier, IHaveTargetIdentifier
    {
        public override string AWSTypeName { get => AWS.ControlTower.EnabledControl; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledcontrol.html#cfn-controltower-enabledcontrol-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnabledControlParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter>, IReadOnlyList<Union<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }

        /// <summary>
        /// ControlIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledcontrol.html#cfn-controltower-enabledcontrol-controlidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ControlIdentifier { get; set; }

        /// <summary>
        /// TargetIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledcontrol.html#cfn-controltower-enabledcontrol-targetidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledcontrol.html#cfn-controltower-enabledcontrol-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EnabledControlTypes
    {
        public class EnabledControlParameter : Humidifier.Base.BaseSubResource, IHaveValue_Json, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controltower-enabledcontrol-enabledcontrolparameter.html#cfn-controltower-enabledcontrol-enabledcontrolparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controltower-enabledcontrol-enabledcontrolparameter.html#cfn-controltower-enabledcontrol-enabledcontrolparameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}