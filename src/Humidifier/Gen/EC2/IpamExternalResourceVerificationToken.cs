namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class IpamExternalResourceVerificationToken : Humidifier.Base.BaseResource, IHaveTags, IHaveIpamId
    {
        public class Attributes
        {
            public static string IpamExternalResourceVerificationTokenId =  "IpamExternalResourceVerificationTokenId" ;
            public static string Status =  "Status" ;
            public static string IpamArn =  "IpamArn" ;
            public static string State =  "State" ;
            public static string IpamExternalResourceVerificationTokenArn =  "IpamExternalResourceVerificationTokenArn" ;
            public static string TokenName =  "TokenName" ;
            public static string NotAfter =  "NotAfter" ;
            public static string IpamRegion =  "IpamRegion" ;
            public static string TokenValue =  "TokenValue" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IpamExternalResourceVerificationToken; }

        /// <summary>
        /// IpamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamexternalresourceverificationtoken.html#cfn-ec2-ipamexternalresourceverificationtoken-ipamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamexternalresourceverificationtoken.html#cfn-ec2-ipamexternalresourceverificationtoken-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}