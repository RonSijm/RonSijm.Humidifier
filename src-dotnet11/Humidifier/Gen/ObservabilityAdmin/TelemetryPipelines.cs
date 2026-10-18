namespace Humidifier.ObservabilityAdmin
{
    using global::System.Collections.Generic;
    using TelemetryPipelinesTypes;

    public class TelemetryPipelines : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveObservabilityAdminTelemetryPipelinesTypesTelemetryPipelineConfigurationConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StatusReason =  "StatusReason" ;
            public static string Pipeline =  "Pipeline" ;
            public static string PipelineIdentifier =  "PipelineIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ObservabilityAdmin.TelemetryPipelines; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-telemetrypipelines.html#cfn-observabilityadmin-telemetrypipelines-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TelemetryPipelineConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-telemetrypipelines.html#cfn-observabilityadmin-telemetrypipelines-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TelemetryPipelinesTypes
    {
        public class TelemetryPipeline : Humidifier.Base.BaseSubResource, IHaveTags, IHaveStatus, IHaveLastUpdateTimeStamp_Double, IHaveCreatedTimeStamp_Double, IHaveObservabilityAdminTelemetryPipelinesTypesTelemetryPipelineConfigurationConfiguration, IHaveObservabilityAdminTelemetryPipelinesTypesTelemetryPipelineStatusReasonStatusReason, IHaveArn, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// LastUpdateTimeStamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-lastupdatetimestamp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LastUpdateTimeStamp { get; set; }
            /// <summary>
            /// CreatedTimeStamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-createdtimestamp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CreatedTimeStamp { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelemetryPipelineConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelemetryPipelineStatusReason
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineStatusReason, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipeline.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipeline-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TelemetryPipelineConfiguration : Humidifier.Base.BaseSubResource, IHaveBody
        {
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipelineconfiguration.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipelineconfiguration-body
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
        }

        public class TelemetryPipelineStatusReason : Humidifier.Base.BaseSubResource, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetrypipelines-telemetrypipelinestatusreason.html#cfn-observabilityadmin-telemetrypipelines-telemetrypipelinestatusreason-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
        }
    }
}