namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using CommandTypes;

    public class Command : Humidifier.Base.BaseResource, IHaveTags, IHavePayloadTemplate, IHaveDescription, IHaveLastUpdatedAt, IHaveCreatedAt, IHaveListOfIoTCommandTypesCommandParameterMandatoryParameters, IHaveNamespace_, IHaveRoleArn, IHaveDeprecated_Boolean, IHaveDisplayName, IHaveIoTCommandTypesCommandPayloadPayload, IHaveCommandId, IHaveIoTCommandTypesCommandPreprocessorPreprocessor, IHavePendingDeletion_Boolean
    {
        public class Attributes
        {
            public static string CommandArn =  "CommandArn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.Command; }
        /// <summary>
        /// PayloadTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-payloadtemplate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PayloadTemplate { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// LastUpdatedAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-lastupdatedat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LastUpdatedAt { get; set; }
        /// <summary>
        /// CreatedAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-createdat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CreatedAt { get; set; }
        /// <summary>
        /// MandatoryParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-mandatoryparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CommandParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoT.CommandTypes.CommandParameter>, IReadOnlyList<Union<Humidifier.IoT.CommandTypes.CommandParameter, BaseFunction>>, BaseFunction>? MandatoryParameters { get; set; }
        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-namespace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Deprecated
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-deprecated
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Deprecated { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// Payload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-payload
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CommandPayload
        /// </summary>
        public Union<Humidifier.IoT.CommandTypes.CommandPayload, BaseFunction>? Payload { get; set; }

        /// <summary>
        /// CommandId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-commandid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CommandId { get; set; }
        /// <summary>
        /// Preprocessor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-preprocessor
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CommandPreprocessor
        /// </summary>
        public Union<Humidifier.IoT.CommandTypes.CommandPreprocessor, BaseFunction>? Preprocessor { get; set; }
        /// <summary>
        /// PendingDeletion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-pendingdeletion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PendingDeletion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CommandTypes
    {
        public class AwsJsonSubstitutionCommandPreprocessorConfig : Humidifier.Base.BaseSubResource, IHaveOutputFormat
        {
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-awsjsonsubstitutioncommandpreprocessorconfig.html#cfn-iot-command-awsjsonsubstitutioncommandpreprocessorconfig-outputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
        }

        public class CommandParameter : Humidifier.Base.BaseSubResource, IHaveIoTCommandTypesCommandParameterValueDefaultValue, IHaveType, IHaveDescription, IHaveIoTCommandTypesCommandParameterValueValue, IHaveListOfIoTCommandTypesCommandParameterValueConditionValueConditions, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommandParameterValue
            /// </summary>
            public Union<Humidifier.IoT.CommandTypes.CommandParameterValue, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommandParameterValue
            /// </summary>
            public Union<Humidifier.IoT.CommandTypes.CommandParameterValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// ValueConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-valueconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CommandParameterValueCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.CommandTypes.CommandParameterValueCondition>, IReadOnlyList<Union<Humidifier.IoT.CommandTypes.CommandParameterValueCondition, BaseFunction>>, BaseFunction>? ValueConditions { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CommandParameterValue : Humidifier.Base.BaseSubResource, IHaveB_Boolean, IHaveS, IHaveD_Double, IHaveBIN, IHaveUL, IHaveI_Integer, IHaveL
        {
            /// <summary>
            /// B
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-b
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? B { get; set; }
            /// <summary>
            /// S
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-s
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S { get; set; }
            /// <summary>
            /// D
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-d
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? D { get; set; }
            /// <summary>
            /// BIN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-bin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BIN { get; set; }
            /// <summary>
            /// UL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-ul
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UL { get; set; }
            /// <summary>
            /// I
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-i
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? I { get; set; }
            /// <summary>
            /// L
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-l
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? L { get; set; }
        }

        public class CommandParameterValueComparisonOperand : Humidifier.Base.BaseSubResource, IHaveIoTCommandTypesCommandParameterValueNumberRangeNumberRange, IHaveStringListOfNumbers, IHaveNumber, IHaveString, IHaveStringListOfStrings
        {
            /// <summary>
            /// NumberRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecomparisonoperand.html#cfn-iot-command-commandparametervaluecomparisonoperand-numberrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommandParameterValueNumberRange
            /// </summary>
            public Union<Humidifier.IoT.CommandTypes.CommandParameterValueNumberRange, BaseFunction>? NumberRange { get; set; }
            /// <summary>
            /// Numbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecomparisonoperand.html#cfn-iot-command-commandparametervaluecomparisonoperand-numbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Numbers { get; set; }
            /// <summary>
            /// Number
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecomparisonoperand.html#cfn-iot-command-commandparametervaluecomparisonoperand-number
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Number { get; set; }
            /// <summary>
            /// String
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecomparisonoperand.html#cfn-iot-command-commandparametervaluecomparisonoperand-string
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? String { get; set; }
            /// <summary>
            /// Strings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecomparisonoperand.html#cfn-iot-command-commandparametervaluecomparisonoperand-strings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Strings { get; set; }
        }

        public class CommandParameterValueCondition : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveIoTCommandTypesCommandParameterValueComparisonOperandOperand
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecondition.html#cfn-iot-command-commandparametervaluecondition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Operand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluecondition.html#cfn-iot-command-commandparametervaluecondition-operand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CommandParameterValueComparisonOperand
            /// </summary>
            public Union<Humidifier.IoT.CommandTypes.CommandParameterValueComparisonOperand, BaseFunction>? Operand { get; set; }
        }

        public class CommandParameterValueNumberRange : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluenumberrange.html#cfn-iot-command-commandparametervaluenumberrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervaluenumberrange.html#cfn-iot-command-commandparametervaluenumberrange-max
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Max { get; set; }
        }

        public class CommandPayload : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContent
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandpayload.html#cfn-iot-command-commandpayload-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandpayload.html#cfn-iot-command-commandpayload-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
        }

        public class CommandPreprocessor : Humidifier.Base.BaseSubResource, IHaveIoTCommandTypesAwsJsonSubstitutionCommandPreprocessorConfigAwsJsonSubstitution
        {
            /// <summary>
            /// AwsJsonSubstitution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandpreprocessor.html#cfn-iot-command-commandpreprocessor-awsjsonsubstitution
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AwsJsonSubstitutionCommandPreprocessorConfig
            /// </summary>
            public Union<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig, BaseFunction>? AwsJsonSubstitution { get; set; }
        }
    }
}