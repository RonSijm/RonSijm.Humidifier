namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;

    public class TrustStore : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfCertificateList
    {
        public class Attributes
        {
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string TrustStoreArn =  "TrustStoreArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.TrustStore; }

        /// <summary>
        /// CertificateList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-truststore.html#cfn-workspacesweb-truststore-certificatelist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CertificateList { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-truststore.html#cfn-workspacesweb-truststore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}