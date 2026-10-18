namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;

    public class IdentityProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringDictionaryOfIdentityProviderDetails, IHavePortalArn, IHaveIdentityProviderName, IHaveIdentityProviderType
    {
        public class Attributes
        {
            public static string IdentityProviderArn =  "IdentityProviderArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.IdentityProvider; }

        /// <summary>
        /// IdentityProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-identityproviderdetails
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? IdentityProviderDetails { get; set; }
        /// <summary>
        /// PortalArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-portalarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PortalArn { get; set; }
        public Union<string, BaseFunction>? IdentityProviderName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// IdentityProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-identityprovidertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-identityprovider.html#cfn-workspacesweb-identityprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}