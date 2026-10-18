namespace Humidifier.IoT
{
    using global::System.Collections.Generic;

    public class ResourceSpecificLogging : Humidifier.Base.BaseResource, IHaveTargetType, IHaveTargetName, IHaveLogLevel
    {
        public class Attributes
        {
            public static string TargetId =  "TargetId" ;
        }

        public override string AWSTypeName { get => AWS.IoT.ResourceSpecificLogging; }

        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-resourcespecificlogging.html#cfn-iot-resourcespecificlogging-targettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetType { get; set; }

        /// <summary>
        /// TargetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-resourcespecificlogging.html#cfn-iot-resourcespecificlogging-targetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetName { get; set; }

        /// <summary>
        /// LogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-resourcespecificlogging.html#cfn-iot-resourcespecificlogging-loglevel
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LogLevel { get; set; }
    }
}