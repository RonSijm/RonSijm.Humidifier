namespace Humidifier.NeptuneGraph
{
    using global::System.Collections.Generic;

    public class PrivateGraphEndpoint : Humidifier.Base.BaseResource, IHaveVpcId, IHaveGraphIdentifier, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
    {
        public class Attributes
        {
            public static string VpcEndpointId =  "VpcEndpointId" ;
            public static string PrivateGraphEndpointIdentifier =  "PrivateGraphEndpointIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.NeptuneGraph.PrivateGraphEndpoint; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-privategraphendpoint.html#cfn-neptunegraph-privategraphendpoint-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// GraphIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-privategraphendpoint.html#cfn-neptunegraph-privategraphendpoint-graphidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GraphIdentifier { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-privategraphendpoint.html#cfn-neptunegraph-privategraphendpoint-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-privategraphendpoint.html#cfn-neptunegraph-privategraphendpoint-subnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
    }
}