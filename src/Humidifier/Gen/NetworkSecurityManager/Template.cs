namespace Humidifier.NetworkSecurityManager
{
    using global::System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTemplateName, IHaveTemplateDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string TemplateArn =  "TemplateArn" ;
            public static string Status =  "Status" ;
            public static string Version =  "Version" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string TemplateId =  "TemplateId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkSecurityManager.Template; }
        /// <summary>
        /// AssociatedRuleList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-template.html#cfn-networksecuritymanager-template-associatedrulelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedRule
        /// </summary>
        public List<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> AssociatedRuleList { get; set; }
        /// <summary>
        /// FirewallType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-template.html#cfn-networksecuritymanager-template-firewalltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FirewallType { get; set; }
        public dynamic TemplateName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TemplateDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-template.html#cfn-networksecuritymanager-template-templatedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TemplateDescription { get; set; }

        [Ignore]
        public dynamic Description { get => TemplateDescription; set => TemplateDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-template.html#cfn-networksecuritymanager-template-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace TemplateTypes
    {
        public class AssociatedRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-template-associatedrule.html#cfn-networksecuritymanager-template-associatedrule-rulearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleArn { get; set; }
        }
    }
}