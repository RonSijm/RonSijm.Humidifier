namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;

    public class EntityRecognizerEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveEndpointName, IHaveModelArn, IHaveDataAccessRoleArn
    {
        public class Attributes
        {
            public static string EndpointStatus =  "EndpointStatus" ;
            public static string CurrentInferenceUnits =  "CurrentInferenceUnits" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.EntityRecognizerEndpoint; }
        /// <summary>
        /// ModelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-modelarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelArn { get; set; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-dataaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataAccessRoleArn { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndpointName { get; set; }

        /// <summary>
        /// DesiredInferenceUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-desiredinferenceunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic DesiredInferenceUnits { get; set; }
        /// <summary>
        /// FlywheelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-flywheelarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FlywheelArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}