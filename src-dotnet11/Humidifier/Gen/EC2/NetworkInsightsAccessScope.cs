namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using NetworkInsightsAccessScopeTypes;

    public class NetworkInsightsAccessScope : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfEC2NetworkInsightsAccessScopeTypesAccessScopePathRequestExcludePaths, IHaveListOfEC2NetworkInsightsAccessScopeTypesAccessScopePathRequestMatchPaths
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
        public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest, BaseFunction>>, BaseFunction>? ExcludePaths { get; set; }
        /// <summary>
        /// MatchPaths
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscope.html#cfn-ec2-networkinsightsaccessscope-matchpaths
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AccessScopePathRequest
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest, BaseFunction>>, BaseFunction>? MatchPaths { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscope.html#cfn-ec2-networkinsightsaccessscope-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace NetworkInsightsAccessScopeTypes
    {
        public class AccessScopePathRequest : Humidifier.Base.BaseSubResource, IHaveListOfEC2NetworkInsightsAccessScopeTypesThroughResourcesStatementRequestThroughResources, IHaveEC2NetworkInsightsAccessScopeTypesPathStatementRequestDestination, IHaveEC2NetworkInsightsAccessScopeTypesPathStatementRequestSource
        {
            /// <summary>
            /// ThroughResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-accessscopepathrequest.html#cfn-ec2-networkinsightsaccessscope-accessscopepathrequest-throughresources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ThroughResourcesStatementRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ThroughResourcesStatementRequest>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ThroughResourcesStatementRequest, BaseFunction>>, BaseFunction>? ThroughResources { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-accessscopepathrequest.html#cfn-ec2-networkinsightsaccessscope-accessscopepathrequest-destination
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PathStatementRequest
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.PathStatementRequest, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-accessscopepathrequest.html#cfn-ec2-networkinsightsaccessscope-accessscopepathrequest-source
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PathStatementRequest
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.PathStatementRequest, BaseFunction>? Source { get; set; }
        }

        public class PacketHeaderStatementRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfProtocols, IHaveStringListOfDestinationPorts, IHaveStringListOfDestinationAddresses, IHaveStringListOfDestinationPrefixLists, IHaveStringListOfSourceAddresses, IHaveStringListOfSourcePorts, IHaveStringListOfSourcePrefixLists
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-protocols
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Protocols { get; set; }
            /// <summary>
            /// DestinationPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-destinationports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DestinationPorts { get; set; }
            /// <summary>
            /// DestinationAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-destinationaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DestinationAddresses { get; set; }
            /// <summary>
            /// DestinationPrefixLists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-destinationprefixlists
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DestinationPrefixLists { get; set; }
            /// <summary>
            /// SourceAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-sourceaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceAddresses { get; set; }
            /// <summary>
            /// SourcePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-sourceports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourcePorts { get; set; }
            /// <summary>
            /// SourcePrefixLists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-packetheaderstatementrequest.html#cfn-ec2-networkinsightsaccessscope-packetheaderstatementrequest-sourceprefixlists
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourcePrefixLists { get; set; }
        }

        public class PathStatementRequest : Humidifier.Base.BaseSubResource, IHaveEC2NetworkInsightsAccessScopeTypesPacketHeaderStatementRequestPacketHeaderStatement, IHaveEC2NetworkInsightsAccessScopeTypesResourceStatementRequestResourceStatement
        {
            /// <summary>
            /// PacketHeaderStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-pathstatementrequest.html#cfn-ec2-networkinsightsaccessscope-pathstatementrequest-packetheaderstatement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PacketHeaderStatementRequest
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest, BaseFunction>? PacketHeaderStatement { get; set; }
            /// <summary>
            /// ResourceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-pathstatementrequest.html#cfn-ec2-networkinsightsaccessscope-pathstatementrequest-resourcestatement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceStatementRequest
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest, BaseFunction>? ResourceStatement { get; set; }
        }

        public class ResourceStatementRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceTypes, IHaveStringListOfResources
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-resourcestatementrequest.html#cfn-ec2-networkinsightsaccessscope-resourcestatementrequest-resourcetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-resourcestatementrequest.html#cfn-ec2-networkinsightsaccessscope-resourcestatementrequest-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
        }

        public class ThroughResourcesStatementRequest : Humidifier.Base.BaseSubResource, IHaveEC2NetworkInsightsAccessScopeTypesResourceStatementRequestResourceStatement
        {
            /// <summary>
            /// ResourceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsaccessscope-throughresourcesstatementrequest.html#cfn-ec2-networkinsightsaccessscope-throughresourcesstatementrequest-resourcestatement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceStatementRequest
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest, BaseFunction>? ResourceStatement { get; set; }
        }
    }
}