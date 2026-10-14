namespace Humidifier.FIS
{
    using global::System.Collections.Generic;
    using ExperimentTypes;

    public class Experiment : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string EndTime =  "EndTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string StartTime =  "StartTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string RoleArn =  "RoleArn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.FIS.Experiment; }
        /// <summary>
        /// ExperimentOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experiment.html#cfn-fis-experiment-experimentoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExperimentOptions
        /// </summary>
        public Humidifier.FIS.ExperimentTypes.ExperimentOptions ExperimentOptions { get; set; }
        /// <summary>
        /// ExperimentTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experiment.html#cfn-fis-experiment-experimenttemplateid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExperimentTemplateId { get; set; }
    }

    namespace ExperimentTypes
    {
        public class ExperimentOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ActionsMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experiment-experimentoptions.html#cfn-fis-experiment-experimentoptions-actionsmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionsMode { get; set; }
        }
    }
}