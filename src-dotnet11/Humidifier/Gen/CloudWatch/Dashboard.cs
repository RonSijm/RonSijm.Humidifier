namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;

    public class Dashboard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDashboardName, IHaveDashboardBody
    {
        public override string AWSTypeName { get => AWS.CloudWatch.Dashboard; }
        public Union<string, BaseFunction>? DashboardName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DashboardBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html#cfn-cloudwatch-dashboard-dashboardbody
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DashboardBody { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html#cfn-cloudwatch-dashboard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}