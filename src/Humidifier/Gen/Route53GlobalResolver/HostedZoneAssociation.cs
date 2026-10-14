namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;

    public class HostedZoneAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveResourceArn, IHaveHostedZoneId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string HostedZoneName =  "HostedZoneName" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string HostedZoneAssociationId =  "HostedZoneAssociationId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Route53GlobalResolver.HostedZoneAssociation; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-hostedzoneassociation.html#cfn-route53globalresolver-hostedzoneassociation-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-hostedzoneassociation.html#cfn-route53globalresolver-hostedzoneassociation-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HostedZoneId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}