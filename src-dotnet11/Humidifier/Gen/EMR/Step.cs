namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using StepTypes;

    public class Step : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveJobFlowId, IHaveLogUri, IHaveActionOnFailure, IHaveEncryptionKeyArn, IHaveEMRStepTypesHadoopJarStepConfigHadoopJarStep, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EMR.Step; }

        /// <summary>
        /// JobFlowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-jobflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobFlowId { get; set; }
        /// <summary>
        /// LogUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-loguri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogUri { get; set; }

        /// <summary>
        /// ActionOnFailure
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-actiononfailure
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ActionOnFailure { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }

        /// <summary>
        /// HadoopJarStep
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-hadoopjarstep
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HadoopJarStepConfig
        /// </summary>
        [Required]
        public Union<Humidifier.EMR.StepTypes.HadoopJarStepConfig, BaseFunction>? HadoopJarStep { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace StepTypes
    {
        public class HadoopJarStepConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfArgs, IHaveMainClass, IHaveListOfEMRStepTypesKeyValueStepProperties, IHaveJar
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-args
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Args { get; set; }
            /// <summary>
            /// MainClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-mainclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MainClass { get; set; }
            /// <summary>
            /// StepProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-stepproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.StepTypes.KeyValue>, IReadOnlyList<Union<Humidifier.EMR.StepTypes.KeyValue, BaseFunction>>, BaseFunction>? StepProperties { get; set; }
            /// <summary>
            /// Jar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-jar
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Jar { get; set; }
        }

        public class KeyValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-keyvalue.html#cfn-emr-step-keyvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-keyvalue.html#cfn-emr-step-keyvalue-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}