namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using NetworkInsightsAnalysisTypes;

    public class NetworkInsightsAnalysis : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfFilterOutArns, IHaveNetworkInsightsPathId, IHaveStringListOfFilterInArns, IHaveStringListOfAdditionalAccounts
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ReturnPathComponents =  "ReturnPathComponents" ;
            public static string StartDate =  "StartDate" ;
            public static string NetworkInsightsAnalysisId =  "NetworkInsightsAnalysisId" ;
            public static string AlternatePathHints =  "AlternatePathHints" ;
            public static string Explanations =  "Explanations" ;
            public static string NetworkPathFound =  "NetworkPathFound" ;
            public static string SuggestedAccounts =  "SuggestedAccounts" ;
            public static string ForwardPathComponents =  "ForwardPathComponents" ;
            public static string NetworkInsightsAnalysisArn =  "NetworkInsightsAnalysisArn" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInsightsAnalysis; }
        /// <summary>
        /// FilterOutArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-filteroutarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FilterOutArns { get; set; }

        /// <summary>
        /// NetworkInsightsPathId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-networkinsightspathid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkInsightsPathId { get; set; }
        /// <summary>
        /// FilterInArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-filterinarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FilterInArns { get; set; }
        /// <summary>
        /// AdditionalAccounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-additionalaccounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalAccounts { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace NetworkInsightsAnalysisTypes
    {
        public class AdditionalDetail : Humidifier.Base.BaseSubResource, IHaveServiceName, IHaveAdditionalDetailType, IHaveListOfEC2NetworkInsightsAnalysisTypesAnalysisComponentLoadBalancers, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// AdditionalDetailType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-additionaldetailtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalDetailType { get; set; }
            /// <summary>
            /// LoadBalancers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-loadbalancers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AnalysisComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>>, BaseFunction>? LoadBalancers { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-component
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Component { get; set; }
        }

        public class AlternatePathHint : Humidifier.Base.BaseSubResource, IHaveComponentArn, IHaveComponentId
        {
            /// <summary>
            /// ComponentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-alternatepathhint.html#cfn-ec2-networkinsightsanalysis-alternatepathhint-componentarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentArn { get; set; }
            /// <summary>
            /// ComponentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-alternatepathhint.html#cfn-ec2-networkinsightsanalysis-alternatepathhint-componentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentId { get; set; }
        }

        public class AnalysisAclRule : Humidifier.Base.BaseSubResource, IHaveEC2NetworkInsightsAnalysisTypesPortRangePortRange, IHaveEgress_Boolean, IHaveRuleNumber_Integer, IHaveCidr, IHaveProtocol, IHaveRuleAction
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortRange
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange, BaseFunction>? PortRange { get; set; }
            /// <summary>
            /// Egress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-egress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Egress { get; set; }
            /// <summary>
            /// RuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-rulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RuleNumber { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// RuleAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-ruleaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleAction { get; set; }
        }

        public class AnalysisComponent : Humidifier.Base.BaseSubResource, IHaveArn, IHaveId
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysiscomponent.html#cfn-ec2-networkinsightsanalysis-analysiscomponent-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysiscomponent.html#cfn-ec2-networkinsightsanalysis-analysiscomponent-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class AnalysisLoadBalancerListener : Humidifier.Base.BaseSubResource, IHaveInstancePort_Integer, IHaveLoadBalancerPort_Integer
        {
            /// <summary>
            /// InstancePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancerlistener-instanceport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstancePort { get; set; }
            /// <summary>
            /// LoadBalancerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancerlistener-loadbalancerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LoadBalancerPort { get; set; }
        }

        public class AnalysisLoadBalancerTarget : Humidifier.Base.BaseSubResource, IHaveAddress, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentInstance, IHavePort_Integer, IHaveAvailabilityZone
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Instance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-instance
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Instance { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }

        public class AnalysisPacketHeader : Humidifier.Base.BaseSubResource, IHaveListOfEC2NetworkInsightsAnalysisTypesPortRangeDestinationPortRanges, IHaveListOfEC2NetworkInsightsAnalysisTypesPortRangeSourcePortRanges, IHaveProtocol, IHaveStringListOfDestinationAddresses, IHaveStringListOfSourceAddresses
        {
            /// <summary>
            /// DestinationPortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-destinationportranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange, BaseFunction>>, BaseFunction>? DestinationPortRanges { get; set; }
            /// <summary>
            /// SourcePortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-sourceportranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange, BaseFunction>>, BaseFunction>? SourcePortRanges { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// DestinationAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-destinationaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DestinationAddresses { get; set; }
            /// <summary>
            /// SourceAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-sourceaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceAddresses { get; set; }
        }

        public class AnalysisRouteTableRoute : Humidifier.Base.BaseSubResource, IHaveOrigin, IHavedestinationPrefixListId, IHaveTransitGatewayId, IHaveVpcPeeringConnectionId, IHaveinstanceId, IHaveState, IHaveegressOnlyInternetGatewayId, IHavedestinationCidr, IHaveNetworkInterfaceId, IHaveNatGatewayId, IHavegatewayId
        {
            /// <summary>
            /// Origin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-origin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Origin { get; set; }
            /// <summary>
            /// destinationPrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-destinationprefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? destinationPrefixListId { get; set; }
            /// <summary>
            /// TransitGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-transitgatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitGatewayId { get; set; }
            /// <summary>
            /// VpcPeeringConnectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-vpcpeeringconnectionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcPeeringConnectionId { get; set; }
            /// <summary>
            /// instanceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? instanceId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// egressOnlyInternetGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-egressonlyinternetgatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? egressOnlyInternetGatewayId { get; set; }
            /// <summary>
            /// destinationCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-destinationcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? destinationCidr { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// NatGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-natgatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NatGatewayId { get; set; }
            /// <summary>
            /// gatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-gatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? gatewayId { get; set; }
        }

        public class AnalysisSecurityGroupRule : Humidifier.Base.BaseSubResource, IHaveEC2NetworkInsightsAnalysisTypesPortRangePortRange, IHaveCidr, IHaveProtocol, IHavePrefixListId, IHaveDirection, IHaveSecurityGroupId
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortRange
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange, BaseFunction>? PortRange { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// PrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-prefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrefixListId { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-direction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Direction { get; set; }
            /// <summary>
            /// SecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-securitygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityGroupId { get; set; }
        }

        public class Explanation : Humidifier.Base.BaseSubResource, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpnGateway, IHavePacketField, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGatewayAttachment, IHaveStringListOfProtocols, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentIngressRouteTable, IHaveEC2NetworkInsightsAnalysisTypesAnalysisLoadBalancerListenerClassicLoadBalancerListener, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpcPeeringConnection, IHaveAddress, IHavePort_Integer, IHaveStringListOfAddresses, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentElasticLoadBalancerListener, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGatewayRouteTable, IHaveExplanationCode, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentInternetGateway, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSourceVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentAttachedTo, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentPrefixList, IHaveEC2NetworkInsightsAnalysisTypesTransitGatewayRouteTableRouteTransitGatewayRouteTableRoute, IHaveComponentRegion, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentLoadBalancerTargetGroup, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentNetworkInterface, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentCustomerGateway, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentDestinationVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSecurityGroup, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGateway, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentRouteTable, IHaveState, IHaveLoadBalancerListenerPort_Integer, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentvpcEndpoint, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSubnet, IHaveStringListOfCidrs, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentDestination, IHaveListOfEC2NetworkInsightsAnalysisTypesAnalysisComponentSecurityGroups, IHaveComponentAccount, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpnConnection, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentNatGateway, IHaveDirection, IHaveLoadBalancerTargetPort_Integer, IHaveEC2NetworkInsightsAnalysisTypesAnalysisLoadBalancerTargetLoadBalancerTarget, IHaveListOfEC2NetworkInsightsAnalysisTypesAnalysisComponentLoadBalancerTargetGroups, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent, IHaveMissingComponent, IHaveEC2NetworkInsightsAnalysisTypesAnalysisRouteTableRouteRouteTableRoute, IHaveStringListOfAvailabilityZones, IHaveListOfEC2NetworkInsightsAnalysisTypesPortRangePortRanges, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentAcl, IHaveEC2NetworkInsightsAnalysisTypesAnalysisSecurityGroupRuleSecurityGroupRule, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSubnetRouteTable, IHaveLoadBalancerArn, IHaveEC2NetworkInsightsAnalysisTypesAnalysisAclRuleAclRule
        {
            /// <summary>
            /// VpnGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpngateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? VpnGateway { get; set; }
            /// <summary>
            /// PacketField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-packetfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PacketField { get; set; }
            /// <summary>
            /// TransitGatewayAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgatewayattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? TransitGatewayAttachment { get; set; }
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-protocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Protocols { get; set; }
            /// <summary>
            /// IngressRouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-ingressroutetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? IngressRouteTable { get; set; }
            /// <summary>
            /// ClassicLoadBalancerListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-classicloadbalancerlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisLoadBalancerListener
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisLoadBalancerListener, BaseFunction>? ClassicLoadBalancerListener { get; set; }
            /// <summary>
            /// VpcPeeringConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpcpeeringconnection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? VpcPeeringConnection { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Addresses { get; set; }
            /// <summary>
            /// ElasticLoadBalancerListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-elasticloadbalancerlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? ElasticLoadBalancerListener { get; set; }
            /// <summary>
            /// TransitGatewayRouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgatewayroutetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? TransitGatewayRouteTable { get; set; }
            /// <summary>
            /// ExplanationCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-explanationcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExplanationCode { get; set; }
            /// <summary>
            /// InternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-internetgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? InternetGateway { get; set; }
            /// <summary>
            /// SourceVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-sourcevpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? SourceVpc { get; set; }
            /// <summary>
            /// AttachedTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-attachedto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? AttachedTo { get; set; }
            /// <summary>
            /// PrefixList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-prefixlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? PrefixList { get; set; }
            /// <summary>
            /// TransitGatewayRouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgatewayroutetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransitGatewayRouteTableRoute
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.TransitGatewayRouteTableRoute, BaseFunction>? TransitGatewayRouteTableRoute { get; set; }
            /// <summary>
            /// ComponentRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-componentregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentRegion { get; set; }
            /// <summary>
            /// LoadBalancerTargetGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertargetgroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? LoadBalancerTargetGroup { get; set; }
            /// <summary>
            /// NetworkInterface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-networkinterface
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? NetworkInterface { get; set; }
            /// <summary>
            /// CustomerGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-customergateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? CustomerGateway { get; set; }
            /// <summary>
            /// DestinationVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-destinationvpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? DestinationVpc { get; set; }
            /// <summary>
            /// SecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-securitygroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? SecurityGroup { get; set; }
            /// <summary>
            /// TransitGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? TransitGateway { get; set; }
            /// <summary>
            /// RouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-routetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? RouteTable { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// LoadBalancerListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancerlistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LoadBalancerListenerPort { get; set; }
            /// <summary>
            /// vpcEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpcendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? vpcEndpoint { get; set; }
            /// <summary>
            /// Subnet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-subnet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Subnet { get; set; }
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-cidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cidrs { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AnalysisComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// ComponentAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-componentaccount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentAccount { get; set; }
            /// <summary>
            /// VpnConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpnconnection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? VpnConnection { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Vpc { get; set; }
            /// <summary>
            /// NatGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-natgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? NatGateway { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-direction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Direction { get; set; }
            /// <summary>
            /// LoadBalancerTargetPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertargetport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LoadBalancerTargetPort { get; set; }
            /// <summary>
            /// LoadBalancerTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisLoadBalancerTarget
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisLoadBalancerTarget, BaseFunction>? LoadBalancerTarget { get; set; }
            /// <summary>
            /// LoadBalancerTargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertargetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AnalysisComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>>, BaseFunction>? LoadBalancerTargetGroups { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-component
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Component { get; set; }
            /// <summary>
            /// MissingComponent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-missingcomponent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MissingComponent { get; set; }
            /// <summary>
            /// RouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-routetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRouteTableRoute
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisRouteTableRoute, BaseFunction>? RouteTableRoute { get; set; }
            /// <summary>
            /// AvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-availabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-portranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
            /// <summary>
            /// Acl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-acl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Acl { get; set; }
            /// <summary>
            /// SecurityGroupRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-securitygrouprule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisSecurityGroupRule
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisSecurityGroupRule, BaseFunction>? SecurityGroupRule { get; set; }
            /// <summary>
            /// SubnetRouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-subnetroutetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? SubnetRouteTable { get; set; }
            /// <summary>
            /// LoadBalancerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadBalancerArn { get; set; }
            /// <summary>
            /// AclRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-aclrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisAclRule
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisAclRule, BaseFunction>? AclRule { get; set; }
        }

        public class PathComponent : Humidifier.Base.BaseSubResource, IHaveListOfEC2NetworkInsightsAnalysisTypesAdditionalDetailAdditionalDetails, IHaveEC2NetworkInsightsAnalysisTypesAnalysisPacketHeaderInboundHeader, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentDestinationVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisSecurityGroupRuleSecurityGroupRule, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGateway, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentElasticLoadBalancerListener, IHaveListOfEC2NetworkInsightsAnalysisTypesExplanationExplanations, IHaveServiceName, IHaveSequenceNumber_Integer, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSourceVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisPacketHeaderOutboundHeader, IHaveEC2NetworkInsightsAnalysisTypesAnalysisAclRuleAclRule, IHaveEC2NetworkInsightsAnalysisTypesTransitGatewayRouteTableRouteTransitGatewayRouteTableRoute, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSubnet, IHaveEC2NetworkInsightsAnalysisTypesAnalysisRouteTableRouteRouteTableRoute
        {
            /// <summary>
            /// AdditionalDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-additionaldetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdditionalDetail
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.AdditionalDetail>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AdditionalDetail, BaseFunction>>, BaseFunction>? AdditionalDetails { get; set; }
            /// <summary>
            /// InboundHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-inboundheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisPacketHeader
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisPacketHeader, BaseFunction>? InboundHeader { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Vpc { get; set; }
            /// <summary>
            /// DestinationVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-destinationvpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? DestinationVpc { get; set; }
            /// <summary>
            /// SecurityGroupRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-securitygrouprule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisSecurityGroupRule
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisSecurityGroupRule, BaseFunction>? SecurityGroupRule { get; set; }
            /// <summary>
            /// TransitGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-transitgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? TransitGateway { get; set; }
            /// <summary>
            /// ElasticLoadBalancerListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-elasticloadbalancerlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? ElasticLoadBalancerListener { get; set; }
            /// <summary>
            /// Explanations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-explanations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Explanation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.NetworkInsightsAnalysisTypes.Explanation>, IReadOnlyList<Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.Explanation, BaseFunction>>, BaseFunction>? Explanations { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// SequenceNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-sequencenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SequenceNumber { get; set; }
            /// <summary>
            /// SourceVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-sourcevpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? SourceVpc { get; set; }
            /// <summary>
            /// OutboundHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-outboundheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisPacketHeader
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisPacketHeader, BaseFunction>? OutboundHeader { get; set; }
            /// <summary>
            /// AclRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-aclrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisAclRule
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisAclRule, BaseFunction>? AclRule { get; set; }
            /// <summary>
            /// TransitGatewayRouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-transitgatewayroutetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransitGatewayRouteTableRoute
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.TransitGatewayRouteTableRoute, BaseFunction>? TransitGatewayRouteTableRoute { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-component
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Component { get; set; }
            /// <summary>
            /// Subnet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-subnet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent, BaseFunction>? Subnet { get; set; }
            /// <summary>
            /// RouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-routetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRouteTableRoute
            /// </summary>
            public Union<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisRouteTableRoute, BaseFunction>? RouteTableRoute { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveFrom_Integer, IHaveTo_Integer
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html#cfn-ec2-networkinsightsanalysis-portrange-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html#cfn-ec2-networkinsightsanalysis-portrange-to
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? To { get; set; }
        }

        public class TransitGatewayRouteTableRoute : Humidifier.Base.BaseSubResource, IHavePrefixListId, IHaveResourceId, IHaveState, IHaveResourceType, IHaveRouteOrigin, IHaveDestinationCidr, IHaveAttachmentId
        {
            /// <summary>
            /// PrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-prefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrefixListId { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// RouteOrigin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-routeorigin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RouteOrigin { get; set; }
            /// <summary>
            /// DestinationCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-destinationcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationCidr { get; set; }
            /// <summary>
            /// AttachmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-attachmentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachmentId { get; set; }
        }
    }
}