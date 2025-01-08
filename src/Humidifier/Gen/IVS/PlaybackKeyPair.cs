namespace Humidifier.IVS
{
    using System.Collections.Generic;

    public class PlaybackKeyPair : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHavePublicKeyMaterial
    {
        public class Attributes
        {
            public static string Fingerprint =  "Fingerprint" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.PlaybackKeyPair; }
        /// <summary>
        /// PublicKeyMaterial
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-playbackkeypair.html#cfn-ivs-playbackkeypair-publickeymaterial
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PublicKeyMaterial { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-playbackkeypair.html#cfn-ivs-playbackkeypair-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}