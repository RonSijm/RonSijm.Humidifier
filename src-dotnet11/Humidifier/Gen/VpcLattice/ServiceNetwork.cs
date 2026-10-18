namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using ServiceNetworkTypes;

    public class ServiceNetwork : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVpcLatticeServiceNetworkTypesSharingConfigSharingConfig, IHaveAuthType, IHaveName
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ServiceNetwork; }
        /// <summary>
        /// SharingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetwork.html#cfn-vpclattice-servicenetwork-sharingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SharingConfig
        /// </summary>
        public Union<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig, BaseFunction>? SharingConfig { get; set; }
        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetwork.html#cfn-vpclattice-servicenetwork-authtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetwork.html#cfn-vpclattice-servicenetwork-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ServiceNetworkTypes
    {
        public class SharingConfig : Humidifier.Base.BaseSubResource, IHaveenabled_Boolean
        {
            /// <summary>
            /// enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetwork-sharingconfig.html#cfn-vpclattice-servicenetwork-sharingconfig-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? enabled { get; set; }
        }
    }
}