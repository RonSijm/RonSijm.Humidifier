namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfAssetIds, IHaveProjectName, IHavePortalId, IHaveProjectDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string ProjectArn =  "ProjectArn" ;
            public static string ProjectId =  "ProjectId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Project; }
        /// <summary>
        /// AssetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-assetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AssetIds { get; set; }
        public Union<string, BaseFunction>? ProjectName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// PortalId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-portalid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PortalId { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-projectdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ProjectDescription; set => ProjectDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}