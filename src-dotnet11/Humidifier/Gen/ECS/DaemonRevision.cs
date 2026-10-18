namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using DaemonRevisionTypes;

    public class DaemonRevision : Humidifier.Base.BaseResource, IHaveEnableECSManagedTags_Boolean, IHavePropagateTags, IHaveEnableExecuteCommand_Boolean
    {
        public class Attributes
        {
            public static string ClusterArn =  "ClusterArn" ;
            public static string DaemonTaskDefinitionArn =  "DaemonTaskDefinitionArn" ;
            public static string DaemonName =  "DaemonName" ;
            public static string ContainerImages =  "ContainerImages" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Cluster =  "Cluster" ;
            public static string DaemonRevisionId =  "DaemonRevisionId" ;
            public static string DaemonRevisionArn =  "DaemonRevisionArn" ;
            public static string DaemonArn =  "DaemonArn" ;
        }

        public override string AWSTypeName { get => AWS.ECS.DaemonRevision; }
        /// <summary>
        /// EnableECSManagedTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemonrevision.html#cfn-ecs-daemonrevision-enableecsmanagedtags
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableECSManagedTags { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemonrevision.html#cfn-ecs-daemonrevision-propagatetags
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PropagateTags { get; set; }
        /// <summary>
        /// EnableExecuteCommand
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemonrevision.html#cfn-ecs-daemonrevision-enableexecutecommand
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableExecuteCommand { get; set; }
    }

    namespace DaemonRevisionTypes
    {
        public class ContainerImage : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveImageDigest, IHaveImage
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemonrevision-containerimage.html#cfn-ecs-daemonrevision-containerimage-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemonrevision-containerimage.html#cfn-ecs-daemonrevision-containerimage-imagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageDigest { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemonrevision-containerimage.html#cfn-ecs-daemonrevision-containerimage-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
        }
    }
}