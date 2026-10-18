namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ImageUsageReportTypes;

    public class ImageUsageReport : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfEC2ImageUsageReportTypesImageUsageResourceTypeResourceTypes, IHaveStringListOfAccountIds, IHaveImageId
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ReportId =  "ReportId" ;
            public static string Arn =  "Arn" ;
            public static string ExpirationTime =  "ExpirationTime" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ImageUsageReport; }

        /// <summary>
        /// ResourceTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-imageusagereport.html#cfn-ec2-imageusagereport-resourcetypes
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ImageUsageResourceType
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType>, IReadOnlyList<Union<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
        /// <summary>
        /// AccountIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-imageusagereport.html#cfn-ec2-imageusagereport-accountids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }

        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-imageusagereport.html#cfn-ec2-imageusagereport-imageid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ImageId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-imageusagereport.html#cfn-ec2-imageusagereport-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ImageUsageReportTypes
    {
        public class ImageUsageResourceType : Humidifier.Base.BaseSubResource, IHaveListOfEC2ImageUsageReportTypesImageUsageResourceTypeOptionResourceTypeOptions, IHaveResourceType
        {
            /// <summary>
            /// ResourceTypeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-imageusagereport-imageusageresourcetype.html#cfn-ec2-imageusagereport-imageusageresourcetype-resourcetypeoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ImageUsageResourceTypeOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceTypeOption>, IReadOnlyList<Union<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceTypeOption, BaseFunction>>, BaseFunction>? ResourceTypeOptions { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-imageusagereport-imageusageresourcetype.html#cfn-ec2-imageusagereport-imageusageresourcetype-resourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
        }

        public class ImageUsageResourceTypeOption : Humidifier.Base.BaseSubResource, IHaveStringListOfOptionValues, IHaveOptionName
        {
            /// <summary>
            /// OptionValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-imageusagereport-imageusageresourcetypeoption.html#cfn-ec2-imageusagereport-imageusageresourcetypeoption-optionvalues
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OptionValues { get; set; }
            /// <summary>
            /// OptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-imageusagereport-imageusageresourcetypeoption.html#cfn-ec2-imageusagereport-imageusageresourcetypeoption-optionname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptionName { get; set; }
        }
    }
}