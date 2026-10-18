namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using AppBlockBuilderTypes;

    public class AppBlockBuilder : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHavePlatform, IHaveAppStreamAppBlockBuilderTypesVpcConfigVpcConfig, IHaveDisableIMDSV1_Boolean, IHaveStringListOfAppBlockArns, IHaveEnableDefaultInternetAccess_Boolean, IHaveDisplayName, IHaveIamRoleArn, IHaveInstanceType, IHaveName, IHaveListOfAppStreamAppBlockBuilderTypesAccessEndpointAccessEndpoints
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppStream.AppBlockBuilder; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Platform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-platform
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Platform { get; set; }

        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-vpcconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        [Required]
        public Union<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// DisableIMDSV1
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-disableimdsv1
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DisableIMDSV1 { get; set; }
        /// <summary>
        /// AppBlockArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-appblockarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AppBlockArns { get; set; }
        /// <summary>
        /// EnableDefaultInternetAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-enabledefaultinternetaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableDefaultInternetAccess { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-iamrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IamRoleArn { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-instancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AccessEndpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-appblockbuilder.html#cfn-appstream-appblockbuilder-accessendpoints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessEndpoint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint>, IReadOnlyList<Union<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint, BaseFunction>>, BaseFunction>? AccessEndpoints { get; set; }
    }

    namespace AppBlockBuilderTypes
    {
        public class AccessEndpoint : Humidifier.Base.BaseSubResource, IHaveEndpointType, IHaveVpceId
        {
            /// <summary>
            /// EndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblockbuilder-accessendpoint.html#cfn-appstream-appblockbuilder-accessendpoint-endpointtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointType { get; set; }
            /// <summary>
            /// VpceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblockbuilder-accessendpoint.html#cfn-appstream-appblockbuilder-accessendpoint-vpceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpceId { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblockbuilder-vpcconfig.html#cfn-appstream-appblockbuilder-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-appblockbuilder-vpcconfig.html#cfn-appstream-appblockbuilder-vpcconfig-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}