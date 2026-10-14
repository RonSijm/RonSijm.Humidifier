namespace Humidifier.AuditManager
{
    using global::System.Collections.Generic;
    using AssessmentFrameworkTypes;

    public class AssessmentFramework : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string LastUpdatedBy =  "LastUpdatedBy" ;
            public static string Type =  "Type" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FrameworkId =  "FrameworkId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AuditManager.AssessmentFramework; }

        /// <summary>
        /// ControlSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-controlsets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ControlSet
        /// </summary>
        [Required]
        public List<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> ControlSets { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ComplianceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-compliancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ComplianceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AssessmentFrameworkTypes
    {
        public class ControlSet : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Controls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessmentframework-controlset.html#cfn-auditmanager-assessmentframework-controlset-controls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlSetControl
            /// </summary>
            public List<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSetControl> Controls { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessmentframework-controlset.html#cfn-auditmanager-assessmentframework-controlset-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ControlSetControl : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessmentframework-controlsetcontrol.html#cfn-auditmanager-assessmentframework-controlsetcontrol-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }
    }
}