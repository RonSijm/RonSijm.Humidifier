namespace Humidifier.AppRunner
{
    using System.Collections.Generic;

    public class VpcConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSubnets, IHaveSecurityGroups
    {
        public class Attributes
        {
            public static string VpcConnectorArn =  "VpcConnectorArn" ;
            public static string VpcConnectorRevision =  "VpcConnectorRevision" ;
        }

        public override string AWSTypeName { get => AWS.AppRunner.VpcConnector; }
        /// <summary>
        /// SecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcconnector.html#cfn-apprunner-vpcconnector-securitygroups
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroups { get; set; }

        /// <summary>
        /// Subnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcconnector.html#cfn-apprunner-vpcconnector-subnets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Subnets { get; set; }
        public dynamic VpcConnectorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcconnector.html#cfn-apprunner-vpcconnector-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}