namespace Humidifier.SES
{
    using System.Collections.Generic;
    using VdmAttributesTypes;

    public class VdmAttributes : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string VdmAttributesResourceId =  "VdmAttributesResourceId" ;
        }

        public override string AWSTypeName { get => AWS.SES.VdmAttributes; }
        /// <summary>
        /// DashboardAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-vdmattributes.html#cfn-ses-vdmattributes-dashboardattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashboardAttributes
        /// </summary>
        public Humidifier.SES.VdmAttributesTypes.DashboardAttributes DashboardAttributes { get; set; }
        /// <summary>
        /// GuardianAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-vdmattributes.html#cfn-ses-vdmattributes-guardianattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GuardianAttributes
        /// </summary>
        public Humidifier.SES.VdmAttributesTypes.GuardianAttributes GuardianAttributes { get; set; }
    }

    namespace VdmAttributesTypes
    {
        public class DashboardAttributes : Humidifier.Base.BaseSubResource, IHaveEngagementMetrics
        {
            /// <summary>
            /// EngagementMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-vdmattributes-dashboardattributes.html#cfn-ses-vdmattributes-dashboardattributes-engagementmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EngagementMetrics { get; set; }
        }

        public class GuardianAttributes : Humidifier.Base.BaseSubResource, IHaveOptimizedSharedDelivery
        {
            /// <summary>
            /// OptimizedSharedDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-vdmattributes-guardianattributes.html#cfn-ses-vdmattributes-guardianattributes-optimizedshareddelivery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedSharedDelivery { get; set; }
        }
    }
}