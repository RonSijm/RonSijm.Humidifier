namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;

    public class EntityRecognizerEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveModelArn, IHaveDataAccessRoleArn, IHaveEndpointName, IHaveDesiredInferenceUnits_Integer, IHaveFlywheelArn
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
        public Union<string, BaseFunction>? ModelArn { get; set; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-dataaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }

        /// <summary>
        /// DesiredInferenceUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-desiredinferenceunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? DesiredInferenceUnits { get; set; }
        /// <summary>
        /// FlywheelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-flywheelarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlywheelArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizerendpoint.html#cfn-comprehend-entityrecognizerendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}