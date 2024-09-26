namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;
    using StandardTypes;

    public class Standard : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string StandardsSubscriptionArn =  "StandardsSubscriptionArn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.Standard; }

        /// <summary>
        /// StandardsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-standard.html#cfn-securityhub-standard-standardsarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StandardsArn { get; set; }
        /// <summary>
        /// DisabledStandardsControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-standard.html#cfn-securityhub-standard-disabledstandardscontrols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StandardsControl
        /// </summary>
        public List<Humidifier.SecurityHub.StandardTypes.StandardsControl> DisabledStandardsControls { get; set; }
    }

    namespace StandardTypes
    {
        public class StandardsControl : Humidifier.Base.BaseSubResource, IHaveReason
        {
            /// <summary>
            /// StandardsControlArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-standard-standardscontrol.html#cfn-securityhub-standard-standardscontrol-standardscontrolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StandardsControlArn { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-standard-standardscontrol.html#cfn-securityhub-standard-standardscontrol-reason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Reason { get; set; }
        }
    }
}