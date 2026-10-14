namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using ChannelFlowTypes;

    public class ChannelFlow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string AppInstanceId =  "AppInstanceId" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string LastUpdatedTimestamp =  "LastUpdatedTimestamp" ;
            public static string ChannelFlowId =  "ChannelFlowId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.ChannelFlow; }

        /// <summary>
        /// AppInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channelflow.html#cfn-chime-channelflow-appinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppInstanceArn { get; set; }

        /// <summary>
        /// Processors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channelflow.html#cfn-chime-channelflow-processors
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Processor
        /// </summary>
        [Required]
        public List<Humidifier.Chime.ChannelFlowTypes.Processor> Processors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channelflow.html#cfn-chime-channelflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ChannelFlowTypes
    {
        public class LambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHaveInvocationType
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-lambdaconfiguration.html#cfn-chime-channelflow-lambdaconfiguration-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-lambdaconfiguration.html#cfn-chime-channelflow-lambdaconfiguration-invocationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationType { get; set; }
        }

        public class Processor : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-processor.html#cfn-chime-channelflow-processor-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProcessorConfiguration
            /// </summary>
            public Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration Configuration { get; set; }
            /// <summary>
            /// ExecutionOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-processor.html#cfn-chime-channelflow-processor-executionorder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExecutionOrder { get; set; }
            /// <summary>
            /// FallbackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-processor.html#cfn-chime-channelflow-processor-fallbackaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackAction { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-processor.html#cfn-chime-channelflow-processor-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ProcessorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channelflow-processorconfiguration.html#cfn-chime-channelflow-processorconfiguration-lambda
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaConfiguration
            /// </summary>
            public Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration Lambda { get; set; }
        }
    }
}