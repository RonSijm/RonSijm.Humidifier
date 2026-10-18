namespace Humidifier.AppRunner
{
    using global::System.Collections.Generic;

    public class VpcConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets, IHaveVpcConnectorName
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
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }

        /// <summary>
        /// Subnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcconnector.html#cfn-apprunner-vpcconnector-subnets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        public Union<string, BaseFunction>? VpcConnectorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcconnector.html#cfn-apprunner-vpcconnector-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}