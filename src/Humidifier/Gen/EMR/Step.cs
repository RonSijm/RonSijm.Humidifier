namespace Humidifier.EMR
{
    using System.Collections.Generic;
    using StepTypes;

    public class Step : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveJobFlowId, IHaveActionOnFailure
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
        public dynamic JobFlowId { get; set; }

        /// <summary>
        /// ActionOnFailure
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-actiononfailure
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ActionOnFailure { get; set; }

        /// <summary>
        /// HadoopJarStep
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-emr-step-hadoopjarstep
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HadoopJarStepConfig
        /// </summary>
        [Required]
        public Humidifier.EMR.StepTypes.HadoopJarStepConfig HadoopJarStep { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace StepTypes
    {
        public class HadoopJarStepConfig : Humidifier.Base.BaseSubResource, IHaveArgs, IHaveJar, IHaveMainClass
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-args
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Args { get; set; }
            /// <summary>
            /// MainClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-mainclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MainClass { get; set; }
            /// <summary>
            /// StepProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-stepproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public List<Humidifier.EMR.StepTypes.KeyValue> StepProperties { get; set; }
            /// <summary>
            /// Jar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html#cfn-emr-step-hadoopjarstepconfig-jar
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Jar { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-keyvalue.html#cfn-emr-step-keyvalue-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}