namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;

    public class DocumentClassifierEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveModelArn, IHaveEndpointName, IHaveDesiredInferenceUnits_Integer
    {
        public class Attributes
        {
            public static string CurrentInferenceUnits =  "CurrentInferenceUnits" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.DocumentClassifierEndpoint; }

        /// <summary>
        /// ModelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifierendpoint.html#cfn-comprehend-documentclassifierendpoint-modelarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelArn { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifierendpoint.html#cfn-comprehend-documentclassifierendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }

        /// <summary>
        /// DesiredInferenceUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifierendpoint.html#cfn-comprehend-documentclassifierendpoint-desiredinferenceunits
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? DesiredInferenceUnits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifierendpoint.html#cfn-comprehend-documentclassifierendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}