namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using StandardTypes;

    public class Standard : Humidifier.Base.BaseResource, IHaveStandardsArn, IHaveListOfSecurityHubStandardTypesStandardsControlDisabledStandardsControls
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
        public Union<string, BaseFunction>? StandardsArn { get; set; }
        /// <summary>
        /// DisabledStandardsControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-standard.html#cfn-securityhub-standard-disabledstandardscontrols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StandardsControl
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SecurityHub.StandardTypes.StandardsControl>, IReadOnlyList<Union<Humidifier.SecurityHub.StandardTypes.StandardsControl, BaseFunction>>, BaseFunction>? DisabledStandardsControls { get; set; }
    }

    namespace StandardTypes
    {
        public class StandardsControl : Humidifier.Base.BaseSubResource, IHaveStandardsControlArn, IHaveReason
        {
            /// <summary>
            /// StandardsControlArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-standard-standardscontrol.html#cfn-securityhub-standard-standardscontrol-standardscontrolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StandardsControlArn { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-standard-standardscontrol.html#cfn-securityhub-standard-standardscontrol-reason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }
    }
}