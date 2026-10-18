namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCEncryptionControlTypes;

    public class VPCEncryptionControl : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcPeeringExclusionInput, IHaveElasticFileSystemExclusionInput, IHaveVpcLatticeExclusionInput, IHaveVpcId, IHaveNatGatewayExclusionInput, IHaveEgressOnlyInternetGatewayExclusionInput, IHaveVirtualPrivateGatewayExclusionInput, IHaveMode, IHaveInternetGatewayExclusionInput, IHaveLambdaExclusionInput
    {
        public class Attributes
        {
            public static string VpcEncryptionControlId =  "VpcEncryptionControlId" ;
            public static string StateMessage =  "StateMessage" ;
            public static string State =  "State" ;
            public static string ResourceExclusions =  "ResourceExclusions" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCEncryptionControl; }
        /// <summary>
        /// VpcPeeringExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-vpcpeeringexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcPeeringExclusionInput { get; set; }
        /// <summary>
        /// ElasticFileSystemExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-elasticfilesystemexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ElasticFileSystemExclusionInput { get; set; }
        /// <summary>
        /// VpcLatticeExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-vpclatticeexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcLatticeExclusionInput { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// NatGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-natgatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NatGatewayExclusionInput { get; set; }
        /// <summary>
        /// EgressOnlyInternetGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-egressonlyinternetgatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EgressOnlyInternetGatewayExclusionInput { get; set; }
        /// <summary>
        /// VirtualPrivateGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-virtualprivategatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VirtualPrivateGatewayExclusionInput { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-mode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// InternetGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-internetgatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InternetGatewayExclusionInput { get; set; }
        /// <summary>
        /// LambdaExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-lambdaexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LambdaExclusionInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VPCEncryptionControlTypes
    {
        public class ResourceExclusions : Humidifier.Base.BaseSubResource, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionElasticFileSystem, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionVpcLattice, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionVpcPeering, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionInternetGateway, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionEgressOnlyInternetGateway, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionVirtualPrivateGateway, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionNatGateway, IHaveEC2VPCEncryptionControlTypesVpcEncryptionControlExclusionLambda
        {
            /// <summary>
            /// ElasticFileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-elasticfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? ElasticFileSystem { get; set; }
            /// <summary>
            /// VpcLattice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-vpclattice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? VpcLattice { get; set; }
            /// <summary>
            /// VpcPeering
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-vpcpeering
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? VpcPeering { get; set; }
            /// <summary>
            /// InternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-internetgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? InternetGateway { get; set; }
            /// <summary>
            /// EgressOnlyInternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-egressonlyinternetgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? EgressOnlyInternetGateway { get; set; }
            /// <summary>
            /// VirtualPrivateGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-virtualprivategateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? VirtualPrivateGateway { get; set; }
            /// <summary>
            /// NatGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-natgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? NatGateway { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Union<Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion, BaseFunction>? Lambda { get; set; }
        }

        public class VpcEncryptionControlExclusion : Humidifier.Base.BaseSubResource, IHaveStateMessage, IHaveState
        {
            /// <summary>
            /// StateMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion.html#cfn-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion-statemessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateMessage { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion.html#cfn-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }
    }
}