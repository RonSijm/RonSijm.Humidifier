namespace Humidifier.Route53
{
    using System.Collections.Generic;

    public class KeySigningKey : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveStatus, IHaveHostedZoneId
    {
        public override string AWSTypeName { get => AWS.Route53.KeySigningKey; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-keysigningkey.html#cfn-route53-keysigningkey-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Status { get; set; }

        /// <summary>
        /// KeyManagementServiceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-keysigningkey.html#cfn-route53-keysigningkey-keymanagementservicearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KeyManagementServiceArn { get; set; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-keysigningkey.html#cfn-route53-keysigningkey-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HostedZoneId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}