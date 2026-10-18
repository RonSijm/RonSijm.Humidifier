namespace Humidifier.RAM
{
    using global::System.Collections.Generic;

    public class Permission : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResourceType, IHavePolicyTemplate_Json, IHaveName
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string PermissionType =  "PermissionType" ;
            public static string Arn =  "Arn" ;
            public static string IsResourceTypeDefault =  "IsResourceTypeDefault" ;
        }

        public override string AWSTypeName { get => AWS.RAM.Permission; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceType { get; set; }

        /// <summary>
        /// PolicyTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-policytemplate
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyTemplate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permission.html#cfn-ram-permission-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}