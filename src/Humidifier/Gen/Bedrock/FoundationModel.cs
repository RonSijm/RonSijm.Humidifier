namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using FoundationModelTypes;

    public class FoundationModel : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ModelArn =  "ModelArn" ;
            public static string ModelName =  "ModelName" ;
            public static string InputModalities =  "InputModalities" ;
            public static string ModelLifecycle =  "ModelLifecycle" ;
            public static string OutputModalities =  "OutputModalities" ;
            public static string ResponseStreamingSupported =  "ResponseStreamingSupported" ;
            public static string ProviderName =  "ProviderName" ;
            public static string CustomizationsSupported =  "CustomizationsSupported" ;
            public static string InferenceTypesSupported =  "InferenceTypesSupported" ;
            public static string ModelId =  "ModelId" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.FoundationModel; }
    }

    namespace FoundationModelTypes
    {
        public class ModelLifecycle : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-foundationmodel-modellifecycle.html#cfn-bedrock-foundationmodel-modellifecycle-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StartOfLifeTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-foundationmodel-modellifecycle.html#cfn-bedrock-foundationmodel-modellifecycle-startoflifetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartOfLifeTime { get; set; }
            /// <summary>
            /// LegacyTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-foundationmodel-modellifecycle.html#cfn-bedrock-foundationmodel-modellifecycle-legacytime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LegacyTime { get; set; }
            /// <summary>
            /// PublicExtendedAccessTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-foundationmodel-modellifecycle.html#cfn-bedrock-foundationmodel-modellifecycle-publicextendedaccesstime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PublicExtendedAccessTime { get; set; }
            /// <summary>
            /// EndOfLifeTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-foundationmodel-modellifecycle.html#cfn-bedrock-foundationmodel-modellifecycle-endoflifetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndOfLifeTime { get; set; }
        }
    }
}