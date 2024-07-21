namespace Humidifier.RAM
{
    using System.Collections.Generic;

    public class Permission : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string PermissionType =  "PermissionType" ;
            public static string Arn =  "Arn" ;
            public static string IsResourceTypeDefault =  "IsResourceTypeDefault" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::RAM::Permission";
            }
        }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceType { get; set; }
        /// <summary>
        /// PolicyTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-policytemplate
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic PolicyTemplate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }
}