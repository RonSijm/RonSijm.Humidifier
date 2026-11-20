namespace Humidifier.Route53
{
    using global::System.Collections.Generic;

    public class RecordSetProtection : Humidifier.Base.BaseResource, IHaveRecordName, IHaveComment, IHaveRecordType, IHaveHostedZoneId
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
        public Union<string, BaseFunction>? RecordName { get; set; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-comment
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Comment { get; set; }

        /// <summary>
        /// RecordType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-recordtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RecordType { get; set; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetprotection.html#cfn-route53-recordsetprotection-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HostedZoneId { get; set; }
    }
}