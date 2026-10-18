namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using SecurityControlTypes;

    public class SecurityControl : Humidifier.Base.BaseResource, IHaveSecurityControlId, IHaveLastUpdateReason, IHaveMapOfSecurityHubSecurityControlTypesParameterConfigurationParameters, IHaveSecurityControlArn
    {
        public override string AWSTypeName { get => AWS.SecurityHub.SecurityControl; }
        /// <summary>
        /// SecurityControlId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-securitycontrol.html#cfn-securityhub-securitycontrol-securitycontrolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityControlId { get; set; }
        /// <summary>
        /// LastUpdateReason
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-securitycontrol.html#cfn-securityhub-securitycontrol-lastupdatereason
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LastUpdateReason { get; set; }

        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-securitycontrol.html#cfn-securityhub-securitycontrol-parameters
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ParameterConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, Humidifier.SecurityHub.SecurityControlTypes.ParameterConfiguration>, IReadOnlyDictionary<string, Union<Humidifier.SecurityHub.SecurityControlTypes.ParameterConfiguration, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// SecurityControlArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-securitycontrol.html#cfn-securityhub-securitycontrol-securitycontrolarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityControlArn { get; set; }
    }

    namespace SecurityControlTypes
    {
        public class ParameterConfiguration : Humidifier.Base.BaseSubResource, IHaveValueType, IHaveSecurityHubSecurityControlTypesParameterValueValue
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parameterconfiguration.html#cfn-securityhub-securitycontrol-parameterconfiguration-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parameterconfiguration.html#cfn-securityhub-securitycontrol-parameterconfiguration-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterValue
            /// </summary>
            public Union<Humidifier.SecurityHub.SecurityControlTypes.ParameterValue, BaseFunction>? Value { get; set; }
        }

        public class ParameterValue : Humidifier.Base.BaseSubResource, IHaveEnum, IHaveInteger_Integer, IHaveStringListOfStringList, IHaveStringListOfEnumList, IHaveIntegerListOfIntegerList, IHaveString, IHaveBoolean_Boolean, IHaveDouble_Double
        {
            /// <summary>
            /// Enum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-enum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Enum { get; set; }
            /// <summary>
            /// Integer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-integer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Integer { get; set; }
            /// <summary>
            /// StringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-stringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringList { get; set; }
            /// <summary>
            /// EnumList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-enumlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnumList { get; set; }
            /// <summary>
            /// IntegerList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-integerlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? IntegerList { get; set; }
            /// <summary>
            /// String
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-string
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? String { get; set; }
            /// <summary>
            /// Boolean
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-boolean
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Boolean { get; set; }
            /// <summary>
            /// Double
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-securitycontrol-parametervalue.html#cfn-securityhub-securitycontrol-parametervalue-double
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Double { get; set; }
        }
    }
}