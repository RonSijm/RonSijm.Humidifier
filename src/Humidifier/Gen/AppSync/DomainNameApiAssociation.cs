namespace Humidifier.AppSync
{
    using System.Collections.Generic;

    public class DomainNameApiAssociation : Humidifier.Base.BaseResource, IHaveDomainName, IHaveApiId
    {
        public class Attributes
        {
            public static string ApiAssociationIdentifier =  "ApiAssociationIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.DomainNameApiAssociation; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainnameapiassociation.html#cfn-appsync-domainnameapiassociation-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-domainnameapiassociation.html#cfn-appsync-domainnameapiassociation-apiid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApiId { get; set; }
    }
}