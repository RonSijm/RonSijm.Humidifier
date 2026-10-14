namespace Humidifier.Cases
{
    using global::System.Collections.Generic;
    using LayoutTypes;

    public class Layout : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDomainId
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LayoutArn =  "LayoutArn" ;
            public static string LayoutId =  "LayoutId" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.Cases.Layout; }
        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-layout.html#cfn-cases-layout-domainid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainId { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-layout.html#cfn-cases-layout-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LayoutContent
        /// </summary>
        [Required]
        public Humidifier.Cases.LayoutTypes.LayoutContent Content { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-layout.html#cfn-cases-layout-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace LayoutTypes
    {
        public class BasicLayout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TopPanel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-basiclayout.html#cfn-cases-layout-basiclayout-toppanel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LayoutSections
            /// </summary>
            public Humidifier.Cases.LayoutTypes.LayoutSections TopPanel { get; set; }
            /// <summary>
            /// MoreInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-basiclayout.html#cfn-cases-layout-basiclayout-moreinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LayoutSections
            /// </summary>
            public Humidifier.Cases.LayoutTypes.LayoutSections MoreInfo { get; set; }
        }

        public class FieldGroup : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-fieldgroup.html#cfn-cases-layout-fieldgroup-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldItem
            /// </summary>
            public List<Humidifier.Cases.LayoutTypes.FieldItem> Fields { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-fieldgroup.html#cfn-cases-layout-fieldgroup-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FieldItem : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-fielditem.html#cfn-cases-layout-fielditem-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class LayoutContent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Basic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-layoutcontent.html#cfn-cases-layout-layoutcontent-basic
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BasicLayout
            /// </summary>
            public Humidifier.Cases.LayoutTypes.BasicLayout Basic { get; set; }
        }

        public class LayoutSections : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-layoutsections.html#cfn-cases-layout-layoutsections-sections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Section
            /// </summary>
            public List<Humidifier.Cases.LayoutTypes.Section> Sections { get; set; }
        }

        public class Section : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-layout-section.html#cfn-cases-layout-section-fieldgroup
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldGroup
            /// </summary>
            public Humidifier.Cases.LayoutTypes.FieldGroup FieldGroup { get; set; }
        }
    }
}