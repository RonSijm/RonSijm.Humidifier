namespace Humidifier.MSK
{
    using global::System.Collections.Generic;
    using ServerlessClusterTypes;

    public class ServerlessCluster : Humidifier.Base.BaseResource, IHaveListOfMSKServerlessClusterTypesVpcConfigVpcConfigs, IHaveClusterName, IHaveMSKServerlessClusterTypesClientAuthenticationClientAuthentication, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MSK.ServerlessCluster; }

        /// <summary>
        /// VpcConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-serverlesscluster.html#cfn-msk-serverlesscluster-vpcconfigs
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: VpcConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MSK.ServerlessClusterTypes.VpcConfig>, IReadOnlyList<Union<Humidifier.MSK.ServerlessClusterTypes.VpcConfig, BaseFunction>>, BaseFunction>? VpcConfigs { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-serverlesscluster.html#cfn-msk-serverlesscluster-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }

        /// <summary>
        /// ClientAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-serverlesscluster.html#cfn-msk-serverlesscluster-clientauthentication
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ClientAuthentication
        /// </summary>
        [Required]
        public Union<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication, BaseFunction>? ClientAuthentication { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-serverlesscluster.html#cfn-msk-serverlesscluster-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ServerlessClusterTypes
    {
        public class ClientAuthentication : Humidifier.Base.BaseSubResource, IHaveMSKServerlessClusterTypesSaslSasl
        {
            /// <summary>
            /// Sasl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-serverlesscluster-clientauthentication.html#cfn-msk-serverlesscluster-clientauthentication-sasl
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Sasl
            /// </summary>
            public Union<Humidifier.MSK.ServerlessClusterTypes.Sasl, BaseFunction>? Sasl { get; set; }
        }

        public class Iam : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-serverlesscluster-iam.html#cfn-msk-serverlesscluster-iam-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class Sasl : Humidifier.Base.BaseSubResource, IHaveMSKServerlessClusterTypesIamIam
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-serverlesscluster-sasl.html#cfn-msk-serverlesscluster-sasl-iam
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Iam
            /// </summary>
            public Union<Humidifier.MSK.ServerlessClusterTypes.Iam, BaseFunction>? Iam { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-serverlesscluster-vpcconfig.html#cfn-msk-serverlesscluster-vpcconfig-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-serverlesscluster-vpcconfig.html#cfn-msk-serverlesscluster-vpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}