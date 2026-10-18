namespace Humidifier.RolesAnywhere
{
    using global::System.Collections.Generic;

    public class CRL : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTrustAnchorArn, IHaveEnabled_Boolean, IHaveCrlData, IHaveName
    {
        public class Attributes
        {
            public static string CrlId =  "CrlId" ;
        }

        public override string AWSTypeName { get => AWS.RolesAnywhere.CRL; }
        /// <summary>
        /// TrustAnchorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-crl.html#cfn-rolesanywhere-crl-trustanchorarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrustAnchorArn { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-crl.html#cfn-rolesanywhere-crl-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }

        /// <summary>
        /// CrlData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-crl.html#cfn-rolesanywhere-crl-crldata
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CrlData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-crl.html#cfn-rolesanywhere-crl-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}