namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using NetworkInsightsAccessScopeTypes;

    public class NetworkInsightsAccessScope : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string UpdatedDate =  "UpdatedDate" ;
            public static string CreatedDate =  "CreatedDate" ;
            public static string NetworkInsightsAccessScopeArn =  "NetworkInsightsAccessScopeArn" ;
            public static string NetworkInsightsAccessScopeId =  "NetworkInsightsAccessScopeId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInsightsAccessScope; }
        /// <summary>
        /// ExcludePaths
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscope.html#cfn-ec2-networkinsightsaccessscope-excludepaths
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AccessScopePathRequest
        /// </summary>
        public List<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> ExcludePaths { get; set; }
        /// <summary>
        /// MatchPaths
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscope.html#cfn-ec2-networkinsightsaccessscope-matchpaths
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AccessScopePathRequest
        /// </summary>
        public List<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> MatchPaths { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscope.html#cfn-ec2-networkinsightsaccessscope-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace NetworkInsightsAccessScopeTypes
    {
        public class AccessScopePathRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-accessscopepathrequest.html#cfn-ec2-networkinsightsaccessscope-accessscopepathrequest-destination
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PathStatementRequest
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAccessScopeTypes.PathStatementRequest Destination { get; set; }
            /// <summary>
            /// ThroughResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-accessscopepathrequest.html#cfn-ec2-networkinsightsaccessscope-accessscopepathrequest-throughresources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ThroughResourcesStatementRequest
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ThroughResourcesStatementRequest> ThroughResources { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-accessscopepathrequest.html#cfn-ec2-networkinsightsaccessscope-accessscopepathrequest-source
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PathStatementRequest
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAccessScopeTypes.PathStatementRequest Source { get; set; }
        }

        public class PacketHeaderStatementRequest : Humidifier.Base.BaseSubResource, IHaveProtocols
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-protocols
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Protocols { get; set; }
            /// <summary>
            /// DestinationPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-destinationports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DestinationPorts { get; set; }
            /// <summary>
            /// DestinationAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-destinationaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DestinationAddresses { get; set; }
            /// <summary>
            /// DestinationPrefixLists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-destinationprefixlists
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DestinationPrefixLists { get; set; }
            /// <summary>
            /// SourceAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-sourceaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SourceAddresses { get; set; }
            /// <summary>
            /// SourcePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-sourceports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SourcePorts { get; set; }
            /// <summary>
            /// SourcePrefixLists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-sourceprefixlists
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SourcePrefixLists { get; set; }
        }

        public class PathStatementRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-pathstatementrequest.html#cfn-ec2-networkinsightsaccessscope-pathstatementrequest-resourcestatement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceStatementRequest
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest ResourceStatement { get; set; }
            /// <summary>
            /// PacketHeaderStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-pathstatementrequest.html#cfn-ec2-networkinsightsaccessscope-pathstatementrequest-packetheaderstatement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PacketHeaderStatementRequest
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest PacketHeaderStatement { get; set; }
        }

        public class ResourceStatementRequest : Humidifier.Base.BaseSubResource, IHaveResources, IHaveResourceTypes
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-resourcestatementrequest.html#cfn-ec2-networkinsightsaccessscope-resourcestatementrequest-resourcetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-resourcestatementrequest.html#cfn-ec2-networkinsightsaccessscope-resourcestatementrequest-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Resources { get; set; }
        }

        public class ThroughResourcesStatementRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-throughresourcesstatementrequest.html#cfn-ec2-networkinsightsaccessscope-throughresourcesstatementrequest-resourcestatement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceStatementRequest
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest ResourceStatement { get; set; }
        }
    }
}