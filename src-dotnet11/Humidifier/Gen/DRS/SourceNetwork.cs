namespace Humidifier.DRS
{
    using global::System.Collections.Generic;

    public class SourceNetwork : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcID, IHaveOriginAccountID, IHaveOriginRegion
    {
        public class Attributes
        {
            public static string SourceNetworkID =  "SourceNetworkID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.DRS.SourceNetwork; }

        /// <summary>
        /// VpcID
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-sourcenetwork.html#cfn-drs-sourcenetwork-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcID { get; set; }

        /// <summary>
        /// OriginAccountID
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-sourcenetwork.html#cfn-drs-sourcenetwork-originaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OriginAccountID { get; set; }

        /// <summary>
        /// OriginRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-sourcenetwork.html#cfn-drs-sourcenetwork-originregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OriginRegion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-sourcenetwork.html#cfn-drs-sourcenetwork-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}