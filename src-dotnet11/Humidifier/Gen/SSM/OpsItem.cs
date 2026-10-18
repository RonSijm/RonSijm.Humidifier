namespace Humidifier.SSM
{
    using global::System.Collections.Generic;

    public class OpsItem : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveCategory, IHavePriority_Integer, IHaveTitle, IHaveSeverity, IHaveSource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string OpsItemId =  "OpsItemId" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string OpsItemType =  "OpsItemType" ;
            public static string OpsItemArn =  "OpsItemArn" ;
            public static string Version =  "Version" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.SSM.OpsItem; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Category
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-category
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Category { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-priority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }

        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-title
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Title { get; set; }
        /// <summary>
        /// Severity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-severity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Severity { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-opsitem.html#cfn-ssm-opsitem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}