namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VPCBlockPublicAccessExclusion : Humidifier.Base.BaseResource, IHaveTags, IHaveInternetGatewayExclusionMode, IHaveVpcId, IHaveSubnetId
    {
        public class Attributes
        {
            public static string ExclusionId =  "ExclusionId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCBlockPublicAccessExclusion; }

        /// <summary>
        /// InternetGatewayExclusionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcblockpublicaccessexclusion.html#cfn-ec2-vpcblockpublicaccessexclusion-internetgatewayexclusionmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InternetGatewayExclusionMode { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcblockpublicaccessexclusion.html#cfn-ec2-vpcblockpublicaccessexclusion-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcblockpublicaccessexclusion.html#cfn-ec2-vpcblockpublicaccessexclusion-subnetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcblockpublicaccessexclusion.html#cfn-ec2-vpcblockpublicaccessexclusion-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}