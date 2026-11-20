namespace Humidifier.Route53
{
    using global::System.Collections.Generic;

    public class RecordSetProtection : Humidifier.Base.BaseResource, IHaveComment, IHaveHostedZoneId
    {
        public override string AWSTypeName { get => AWS.Route53.RecordSetProtection; }

        /// <summary>
        /// RecordName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-recordname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecordName { get; set; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-comment
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Comment { get; set; }

        /// <summary>
        /// RecordType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-recordtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecordType { get; set; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HostedZoneId { get; set; }
    }
}