namespace Humidifier.IoTSiteWise
{
    using System.Collections.Generic;

    public class Dashboard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDashboardName, IHaveProjectId, IHaveDescription
    {
        public class Attributes
        {
            public static string DashboardId =  "DashboardId" ;
            public static string DashboardArn =  "DashboardArn" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Dashboard; }
        public dynamic DashboardName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DashboardDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-dashboarddefinition
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DashboardDefinition { get; set; }
        /// <summary>
        /// ProjectId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-projectid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectId { get; set; }

        /// <summary>
        /// DashboardDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-dashboarddescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DashboardDescription { get; set; }

        [Ignore]
        public dynamic Description { get => DashboardDescription; set => DashboardDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}