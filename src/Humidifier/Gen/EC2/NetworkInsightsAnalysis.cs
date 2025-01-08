namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using NetworkInsightsAnalysisTypes;

    public class NetworkInsightsAnalysis : Humidifier.Base.BaseResource, IHaveTags
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
        /// NetworkInsightsPathId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-networkinsightspathid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkInsightsPathId { get; set; }
        /// <summary>
        /// FilterInArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-filterinarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic FilterInArns { get; set; }
        /// <summary>
        /// AdditionalAccounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-additionalaccounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AdditionalAccounts { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html#cfn-ec2-networkinsightsanalysis-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace NetworkInsightsAnalysisTypes
    {
        public class AdditionalDetail : Humidifier.Base.BaseSubResource, IHaveServiceName, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
            /// <summary>
            /// AdditionalDetailType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-additionaldetailtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdditionalDetailType { get; set; }
            /// <summary>
            /// LoadBalancers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-loadbalancers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AnalysisComponent
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent> LoadBalancers { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-additionaldetail.html#cfn-ec2-networkinsightsanalysis-additionaldetail-component
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Component { get; set; }
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
            public dynamic ComponentArn { get; set; }
            /// <summary>
            /// ComponentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-alternatepathhint.html#cfn-ec2-networkinsightsanalysis-alternatepathhint-componentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentId { get; set; }
        }

        public class AnalysisAclRule : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveCidr, IHaveRuleAction, IHaveEgress, IHaveRuleNumber, IHaveEC2NetworkInsightsAnalysisTypesPortRangePortRange
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortRange
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange PortRange { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
            /// <summary>
            /// RuleAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-ruleaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleAction { get; set; }
            /// <summary>
            /// Egress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-egress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Egress { get; set; }
            /// <summary>
            /// RuleNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-rulenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RuleNumber { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html#cfn-ec2-networkinsightsanalysis-analysisaclrule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class AnalysisComponent : Humidifier.Base.BaseSubResource, IHaveId, IHaveArn
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysiscomponent.html#cfn-ec2-networkinsightsanalysis-analysiscomponent-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysiscomponent.html#cfn-ec2-networkinsightsanalysis-analysiscomponent-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class AnalysisLoadBalancerListener : Humidifier.Base.BaseSubResource, IHaveInstancePort, IHaveLoadBalancerPort
        {
            /// <summary>
            /// InstancePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancerlistener-instanceport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstancePort { get; set; }
            /// <summary>
            /// LoadBalancerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancerlistener-loadbalancerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LoadBalancerPort { get; set; }
        }

        public class AnalysisLoadBalancerTarget : Humidifier.Base.BaseSubResource, IHavePort, IHaveAvailabilityZone, IHaveAddress
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address { get; set; }
            /// <summary>
            /// Instance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-instance
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Instance { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html#cfn-ec2-networkinsightsanalysis-analysisloadbalancertarget-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
        }

        public class AnalysisPacketHeader : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveDestinationAddresses, IHaveSourceAddresses
        {
            /// <summary>
            /// DestinationPortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-destinationportranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange> DestinationPortRanges { get; set; }
            /// <summary>
            /// SourcePortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-sourceportranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange> SourcePortRanges { get; set; }
            /// <summary>
            /// DestinationAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-destinationaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DestinationAddresses { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// SourceAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysispacketheader.html#cfn-ec2-networkinsightsanalysis-analysispacketheader-sourceaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SourceAddresses { get; set; }
        }

        public class AnalysisRouteTableRoute : Humidifier.Base.BaseSubResource, IHaveState, IHaveNetworkInterfaceId, IHaveTransitGatewayId, IHaveOrigin, IHaveVpcPeeringConnectionId, IHaveNatGatewayId
        {
            /// <summary>
            /// Origin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-origin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Origin { get; set; }
            /// <summary>
            /// destinationPrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-destinationprefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic destinationPrefixListId { get; set; }
            /// <summary>
            /// TransitGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-transitgatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransitGatewayId { get; set; }
            /// <summary>
            /// VpcPeeringConnectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-vpcpeeringconnectionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcPeeringConnectionId { get; set; }
            /// <summary>
            /// instanceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic instanceId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// egressOnlyInternetGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-egressonlyinternetgatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic egressOnlyInternetGatewayId { get; set; }
            /// <summary>
            /// destinationCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-destinationcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic destinationCidr { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceId { get; set; }
            /// <summary>
            /// NatGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-natgatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NatGatewayId { get; set; }
            /// <summary>
            /// gatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisroutetableroute.html#cfn-ec2-networkinsightsanalysis-analysisroutetableroute-gatewayid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic gatewayId { get; set; }
        }

        public class AnalysisSecurityGroupRule : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveDirection, IHaveCidr, IHaveSecurityGroupId, IHaveEC2NetworkInsightsAnalysisTypesPortRangePortRange, IHavePrefixListId
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortRange
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange PortRange { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
            /// <summary>
            /// PrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-prefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrefixListId { get; set; }
            /// <summary>
            /// SecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-securitygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityGroupId { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html#cfn-ec2-networkinsightsanalysis-analysissecuritygrouprule-direction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class Explanation : Humidifier.Base.BaseSubResource, IHavePort, IHaveState, IHaveAddress, IHaveDirection, IHaveAvailabilityZones, IHaveCidrs, IHaveProtocols, IHaveLoadBalancerArn, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent, IHaveAddresses, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentElasticLoadBalancerListener, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSourceVpc, IHaveEC2NetworkInsightsAnalysisTypesTransitGatewayRouteTableRouteTransitGatewayRouteTableRoute, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentDestinationVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGateway, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSubnet, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisRouteTableRouteRouteTableRoute, IHaveEC2NetworkInsightsAnalysisTypesAnalysisSecurityGroupRuleSecurityGroupRule, IHaveEC2NetworkInsightsAnalysisTypesAnalysisAclRuleAclRule
        {
            /// <summary>
            /// VpnGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpngateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent VpnGateway { get; set; }
            /// <summary>
            /// PacketField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-packetfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PacketField { get; set; }
            /// <summary>
            /// TransitGatewayAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgatewayattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent TransitGatewayAttachment { get; set; }
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-protocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Protocols { get; set; }
            /// <summary>
            /// IngressRouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-ingressroutetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent IngressRouteTable { get; set; }
            /// <summary>
            /// ClassicLoadBalancerListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-classicloadbalancerlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisLoadBalancerListener
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisLoadBalancerListener ClassicLoadBalancerListener { get; set; }
            /// <summary>
            /// VpcPeeringConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpcpeeringconnection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent VpcPeeringConnection { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Addresses { get; set; }
            /// <summary>
            /// ElasticLoadBalancerListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-elasticloadbalancerlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent ElasticLoadBalancerListener { get; set; }
            /// <summary>
            /// TransitGatewayRouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgatewayroutetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent TransitGatewayRouteTable { get; set; }
            /// <summary>
            /// ExplanationCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-explanationcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExplanationCode { get; set; }
            /// <summary>
            /// InternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-internetgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent InternetGateway { get; set; }
            /// <summary>
            /// SourceVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-sourcevpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent SourceVpc { get; set; }
            /// <summary>
            /// AttachedTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-attachedto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent AttachedTo { get; set; }
            /// <summary>
            /// PrefixList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-prefixlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent PrefixList { get; set; }
            /// <summary>
            /// TransitGatewayRouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgatewayroutetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransitGatewayRouteTableRoute
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.TransitGatewayRouteTableRoute TransitGatewayRouteTableRoute { get; set; }
            /// <summary>
            /// ComponentRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-componentregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentRegion { get; set; }
            /// <summary>
            /// LoadBalancerTargetGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertargetgroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent LoadBalancerTargetGroup { get; set; }
            /// <summary>
            /// NetworkInterface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-networkinterface
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent NetworkInterface { get; set; }
            /// <summary>
            /// CustomerGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-customergateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent CustomerGateway { get; set; }
            /// <summary>
            /// DestinationVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-destinationvpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent DestinationVpc { get; set; }
            /// <summary>
            /// SecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-securitygroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent SecurityGroup { get; set; }
            /// <summary>
            /// TransitGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-transitgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent TransitGateway { get; set; }
            /// <summary>
            /// RouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-routetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent RouteTable { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// LoadBalancerListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancerlistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LoadBalancerListenerPort { get; set; }
            /// <summary>
            /// vpcEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpcendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent vpcEndpoint { get; set; }
            /// <summary>
            /// Subnet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-subnet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Subnet { get; set; }
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-cidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Cidrs { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Destination { get; set; }
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AnalysisComponent
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent> SecurityGroups { get; set; }
            /// <summary>
            /// ComponentAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-componentaccount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentAccount { get; set; }
            /// <summary>
            /// VpnConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpnconnection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent VpnConnection { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Vpc { get; set; }
            /// <summary>
            /// NatGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-natgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent NatGateway { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-direction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
            /// <summary>
            /// LoadBalancerTargetPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertargetport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LoadBalancerTargetPort { get; set; }
            /// <summary>
            /// LoadBalancerTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisLoadBalancerTarget
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisLoadBalancerTarget LoadBalancerTarget { get; set; }
            /// <summary>
            /// LoadBalancerTargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancertargetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AnalysisComponent
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent> LoadBalancerTargetGroups { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-component
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Component { get; set; }
            /// <summary>
            /// MissingComponent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-missingcomponent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MissingComponent { get; set; }
            /// <summary>
            /// RouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-routetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRouteTableRoute
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisRouteTableRoute RouteTableRoute { get; set; }
            /// <summary>
            /// AvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-availabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AvailabilityZones { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-portranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.PortRange> PortRanges { get; set; }
            /// <summary>
            /// Acl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-acl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Acl { get; set; }
            /// <summary>
            /// SecurityGroupRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-securitygrouprule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisSecurityGroupRule
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisSecurityGroupRule SecurityGroupRule { get; set; }
            /// <summary>
            /// SubnetRouteTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-subnetroutetable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent SubnetRouteTable { get; set; }
            /// <summary>
            /// LoadBalancerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-loadbalancerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoadBalancerArn { get; set; }
            /// <summary>
            /// AclRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html#cfn-ec2-networkinsightsanalysis-explanation-aclrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisAclRule
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisAclRule AclRule { get; set; }
        }

        public class PathComponent : Humidifier.Base.BaseSubResource, IHaveServiceName, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentComponent, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentElasticLoadBalancerListener, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSourceVpc, IHaveEC2NetworkInsightsAnalysisTypesTransitGatewayRouteTableRouteTransitGatewayRouteTableRoute, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentDestinationVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentTransitGateway, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentSubnet, IHaveEC2NetworkInsightsAnalysisTypesAnalysisComponentVpc, IHaveEC2NetworkInsightsAnalysisTypesAnalysisRouteTableRouteRouteTableRoute, IHaveEC2NetworkInsightsAnalysisTypesAnalysisSecurityGroupRuleSecurityGroupRule, IHaveEC2NetworkInsightsAnalysisTypesAnalysisAclRuleAclRule
        {
            /// <summary>
            /// AdditionalDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-additionaldetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdditionalDetail
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.AdditionalDetail> AdditionalDetails { get; set; }
            /// <summary>
            /// InboundHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-inboundheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisPacketHeader
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisPacketHeader InboundHeader { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Vpc { get; set; }
            /// <summary>
            /// DestinationVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-destinationvpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent DestinationVpc { get; set; }
            /// <summary>
            /// SecurityGroupRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-securitygrouprule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisSecurityGroupRule
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisSecurityGroupRule SecurityGroupRule { get; set; }
            /// <summary>
            /// TransitGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-transitgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent TransitGateway { get; set; }
            /// <summary>
            /// ElasticLoadBalancerListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-elasticloadbalancerlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent ElasticLoadBalancerListener { get; set; }
            /// <summary>
            /// Explanations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-explanations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Explanation
            /// </summary>
            public List<Humidifier.EC2.NetworkInsightsAnalysisTypes.Explanation> Explanations { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
            /// <summary>
            /// SequenceNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-sequencenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SequenceNumber { get; set; }
            /// <summary>
            /// SourceVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-sourcevpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent SourceVpc { get; set; }
            /// <summary>
            /// OutboundHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-outboundheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisPacketHeader
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisPacketHeader OutboundHeader { get; set; }
            /// <summary>
            /// AclRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-aclrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisAclRule
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisAclRule AclRule { get; set; }
            /// <summary>
            /// TransitGatewayRouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-transitgatewayroutetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransitGatewayRouteTableRoute
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.TransitGatewayRouteTableRoute TransitGatewayRouteTableRoute { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-component
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Component { get; set; }
            /// <summary>
            /// Subnet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-subnet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisComponent
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisComponent Subnet { get; set; }
            /// <summary>
            /// RouteTableRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-pathcomponent.html#cfn-ec2-networkinsightsanalysis-pathcomponent-routetableroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisRouteTableRoute
            /// </summary>
            public Humidifier.EC2.NetworkInsightsAnalysisTypes.AnalysisRouteTableRoute RouteTableRoute { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveFrom, IHaveTo
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html#cfn-ec2-networkinsightsanalysis-portrange-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html#cfn-ec2-networkinsightsanalysis-portrange-to
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic To { get; set; }
        }

        public class TransitGatewayRouteTableRoute : Humidifier.Base.BaseSubResource, IHaveState, IHaveResourceType, IHaveResourceId, IHavePrefixListId
        {
            /// <summary>
            /// PrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-prefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrefixListId { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// RouteOrigin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-routeorigin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RouteOrigin { get; set; }
            /// <summary>
            /// DestinationCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-destinationcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationCidr { get; set; }
            /// <summary>
            /// AttachmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-transitgatewayroutetableroute.html#cfn-ec2-networkinsightsanalysis-transitgatewayroutetableroute-attachmentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttachmentId { get; set; }
        }
    }
}