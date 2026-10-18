namespace Humidifier.ControlTower
{
    using global::System.Collections.Generic;
    using EnabledBaselineTypes;

    public class EnabledBaseline : Humidifier.Base.BaseResource, IHaveTags, IHaveBaselineVersion, IHaveListOfControlTowerEnabledBaselineTypesParameterParameters, IHaveBaselineIdentifier, IHaveTargetIdentifier
    {
        public class Attributes
        {
            public static string EnabledBaselineIdentifier =  "EnabledBaselineIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.ControlTower.EnabledBaseline; }

        /// <summary>
        /// BaselineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledbaseline.html#cfn-controltower-enabledbaseline-baselineversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BaselineVersion { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledbaseline.html#cfn-controltower-enabledbaseline-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Parameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ControlTower.EnabledBaselineTypes.Parameter>, IReadOnlyList<Union<Humidifier.ControlTower.EnabledBaselineTypes.Parameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }

        /// <summary>
        /// BaselineIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledbaseline.html#cfn-controltower-enabledbaseline-baselineidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BaselineIdentifier { get; set; }

        /// <summary>
        /// TargetIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledbaseline.html#cfn-controltower-enabledbaseline-targetidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-enabledbaseline.html#cfn-controltower-enabledbaseline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EnabledBaselineTypes
    {
        public class Parameter : Humidifier.Base.BaseSubResource, IHaveValue_Json, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controltower-enabledbaseline-parameter.html#cfn-controltower-enabledbaseline-parameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controltower-enabledbaseline-parameter.html#cfn-controltower-enabledbaseline-parameter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}