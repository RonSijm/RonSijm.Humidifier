namespace Humidifier.AppRunner
{
    using global::System.Collections.Generic;
    using VpcIngressConnectionTypes;

    public class VpcIngressConnection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVpcIngressConnectionName, IHaveServiceArn, IHaveAppRunnerVpcIngressConnectionTypesIngressVpcConfigurationIngressVpcConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DomainName =  "DomainName" ;
            public static string VpcIngressConnectionArn =  "VpcIngressConnectionArn" ;
        }

        public override string AWSTypeName { get => AWS.AppRunner.VpcIngressConnection; }
        public Union<string, BaseFunction>? VpcIngressConnectionName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ServiceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcingressconnection.html#cfn-apprunner-vpcingressconnection-servicearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcingressconnection.html#cfn-apprunner-vpcingressconnection-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// IngressVpcConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-vpcingressconnection.html#cfn-apprunner-vpcingressconnection-ingressvpcconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IngressVpcConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration, BaseFunction>? IngressVpcConfiguration { get; set; }
    }

    namespace VpcIngressConnectionTypes
    {
        public class IngressVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveVpcEndpointId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-vpcingressconnection-ingressvpcconfiguration.html#cfn-apprunner-vpcingressconnection-ingressvpcconfiguration-vpcid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-vpcingressconnection-ingressvpcconfiguration.html#cfn-apprunner-vpcingressconnection-ingressvpcconfiguration-vpcendpointid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }
    }
}