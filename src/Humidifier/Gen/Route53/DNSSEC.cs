namespace Humidifier.Route53
{
    using System.Collections.Generic;

    public class DNSSEC : Humidifier.Base.BaseResource, IHaveHostedZoneId
    {
        public override string AWSTypeName { get => AWS.Route53.DNSSEC; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-dnssec.html#cfn-route53-dnssec-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HostedZoneId { get; set; }
    }
}