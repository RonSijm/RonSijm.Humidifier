namespace Humidifier.Route53
{
    using global::System.Collections.Generic;

    public class TrafficPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveComment, IHaveDocument, IHaveName
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string Version =  "Version" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53.TrafficPolicy; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-trafficpolicy.html#cfn-route53-trafficpolicy-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Comment { get; set; }

        /// <summary>
        /// Document
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-trafficpolicy.html#cfn-route53-trafficpolicy-document
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Document { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}