namespace Humidifier.OSIS
{
    using global::System.Collections.Generic;

    public class PipelineBlueprint : Humidifier.Base.BaseResource, IHaveBlueprintName
    {
        public class Attributes
        {
            public static string PipelineConfigurationBody =  "PipelineConfigurationBody" ;
            public static string DisplayDescription =  "DisplayDescription" ;
            public static string DisplayName =  "DisplayName" ;
            public static string Service =  "Service" ;
            public static string UseCase =  "UseCase" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.OSIS.PipelineBlueprint; }
        /// <summary>
        /// BlueprintName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipelineblueprint.html#cfn-osis-pipelineblueprint-blueprintname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BlueprintName { get; set; }
    }
}