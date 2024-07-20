namespace Humidifier.WorkSpacesWeb
{
    using System.Collections.Generic;

    public class IdentityProvider : Humidifier.Resource
    {
        public class Attributes
        {
            public static string IdentityProviderArn =  "IdentityProviderArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WorkSpacesWeb::IdentityProvider";
            }
        }

        /// <summary>
        /// IdentityProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-identityproviderdetails
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> IdentityProviderDetails { get; set; }
        /// <summary>
        /// PortalArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-portalarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortalArn { get; set; }
        /// <summary>
        /// IdentityProviderName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-identityprovidername
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityProviderName { get; set; }
        /// <summary>
        /// IdentityProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-identityprovidertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityProviderType { get; set; }
    }
}