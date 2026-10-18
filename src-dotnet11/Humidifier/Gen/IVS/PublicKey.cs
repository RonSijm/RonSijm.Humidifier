namespace Humidifier.IVS
{
    using global::System.Collections.Generic;

    public class PublicKey : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePublicKeyMaterial, IHaveName
    {
        public class Attributes
        {
            public static string Fingerprint =  "Fingerprint" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.PublicKey; }
        /// <summary>
        /// PublicKeyMaterial
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-publickey.html#cfn-ivs-publickey-publickeymaterial
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PublicKeyMaterial { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-publickey.html#cfn-ivs-publickey-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}