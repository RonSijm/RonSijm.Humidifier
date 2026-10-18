namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using WorkspaceIpGroupTypes;

    public class WorkspaceIpGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveGroupName, IHaveListOfWorkSpacesWorkspaceIpGroupTypesIpRuleItemUserRules, IHaveGroupDesc
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
        public Union<string, BaseFunction>? GroupName { get; set; }
        /// <summary>
        /// UserRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-userrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpRuleItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem>, IReadOnlyList<Union<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem, BaseFunction>>, BaseFunction>? UserRules { get; set; }
        /// <summary>
        /// GroupDesc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-groupdesc
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupDesc { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspaceipgroup.html#cfn-workspaces-workspaceipgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkspaceIpGroupTypes
    {
        public class IpRuleItem : Humidifier.Base.BaseSubResource, IHaveIpRule, IHaveRuleDesc
        {
            /// <summary>
            /// IpRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceipgroup-ipruleitem.html#cfn-workspaces-workspaceipgroup-ipruleitem-iprule
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpRule { get; set; }
            /// <summary>
            /// RuleDesc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspaceipgroup-ipruleitem.html#cfn-workspaces-workspaceipgroup-ipruleitem-ruledesc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleDesc { get; set; }
        }
    }
}