namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;

    public class Dashboard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDashboardName, IHaveDashboardDefinition, IHaveProjectId, IHaveDashboardDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string DashboardId =  "DashboardId" ;
            public static string DashboardArn =  "DashboardArn" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Dashboard; }
        public Union<string, BaseFunction>? DashboardName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DashboardDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-dashboarddefinition
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DashboardDefinition { get; set; }
        /// <summary>
        /// ProjectId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-projectid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectId { get; set; }

        /// <summary>
        /// DashboardDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-dashboarddescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DashboardDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => DashboardDescription; set => DashboardDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html#cfn-iotsitewise-dashboard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}