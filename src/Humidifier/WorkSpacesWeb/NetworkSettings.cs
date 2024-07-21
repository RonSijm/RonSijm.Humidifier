namespace Humidifier.WorkSpacesWeb
{
    using System.Collections.Generic;

    public class NetworkSettings : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string NetworkSettingsArn =  "NetworkSettingsArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WorkSpacesWeb::NetworkSettings";
            }
        }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-networksettings.html#cfn-workspacesweb-networksettings-vpcid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-networksettings.html#cfn-workspacesweb-networksettings-securitygroupids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-networksettings.html#cfn-workspacesweb-networksettings-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubnetIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-networksettings.html#cfn-workspacesweb-networksettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}