namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using WorkspaceIpGroupTypes;

    public class WorkspaceIpGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveGroupName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string GroupId =  "GroupId" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.WorkspaceIpGroup; }

        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-groupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupName { get; set; }
        /// <summary>
        /// UserRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-userrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpRuleItem
        /// </summary>
        public List<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> UserRules { get; set; }
        /// <summary>
        /// GroupDesc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-groupdesc
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupDesc { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace WorkspaceIpGroupTypes
    {
        public class IpRuleItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IpRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceipgroup-ipruleitem.html#cfn-workspaces-workspaceipgroup-ipruleitem-iprule
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpRule { get; set; }
            /// <summary>
            /// RuleDesc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceipgroup-ipruleitem.html#cfn-workspaces-workspaceipgroup-ipruleitem-ruledesc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleDesc { get; set; }
        }
    }
}