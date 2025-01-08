namespace Humidifier.IoTSiteWise
{
    using System.Collections.Generic;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProjectName, IHaveProjectDescription, IHaveDescription
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
        public dynamic AssetIds { get; set; }
        public dynamic ProjectName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// PortalId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-portalid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PortalId { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-projectdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ProjectDescription; set => ProjectDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html#cfn-iotsitewise-project-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}