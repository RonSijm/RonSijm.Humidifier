namespace Humidifier.Route53Profiles
{
    using System.Collections.Generic;

    public class ProfileResourceAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveResourceArn, IHaveProfileId
    {
        public class Attributes
        {
            public static string ResourceType =  "ResourceType" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Route53Profiles.ProfileResourceAssociation; }

        /// <summary>
        /// ProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53profiles-profileresourceassociation.html#cfn-route53profiles-profileresourceassociation-profileid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProfileId { get; set; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53profiles-profileresourceassociation.html#cfn-route53profiles-profileresourceassociation-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }
        /// <summary>
        /// ResourceProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53profiles-profileresourceassociation.html#cfn-route53profiles-profileresourceassociation-resourceproperties
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceProperties { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}