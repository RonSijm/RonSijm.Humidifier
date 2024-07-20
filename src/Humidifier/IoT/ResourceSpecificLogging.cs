namespace Humidifier.IoT
{
    using System.Collections.Generic;

    public class ResourceSpecificLogging : Humidifier.Resource
    {
        public class Attributes
        {
            public static string TargetId =  "TargetId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoT::ResourceSpecificLogging";
            }
        }

        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-resourcespecificlogging.html#cfn-iot-resourcespecificlogging-targettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetType { get; set; }
        /// <summary>
        /// TargetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-resourcespecificlogging.html#cfn-iot-resourcespecificlogging-targetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetName { get; set; }
        /// <summary>
        /// LogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-resourcespecificlogging.html#cfn-iot-resourcespecificlogging-loglevel
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogLevel { get; set; }
    }
}