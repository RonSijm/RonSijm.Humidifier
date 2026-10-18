namespace Humidifier.AuditManager
{
    using global::System.Collections.Generic;
    using AssessmentFrameworkTypes;

    public class AssessmentFramework : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfAuditManagerAssessmentFrameworkTypesControlSetControlSets, IHaveDescription, IHaveComplianceType, IHaveName
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
        public Union<IReadOnlyList<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet>, IReadOnlyList<Union<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet, BaseFunction>>, BaseFunction>? ControlSets { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ComplianceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-compliancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComplianceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessmentframework.html#cfn-auditmanager-assessmentframework-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AssessmentFrameworkTypes
    {
        public class ControlSet : Humidifier.Base.BaseSubResource, IHaveListOfAuditManagerAssessmentFrameworkTypesControlSetControlControls, IHaveName
        {
            /// <summary>
            /// Controls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessmentframework-controlset.html#cfn-auditmanager-assessmentframework-controlset-controls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlSetControl
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSetControl>, IReadOnlyList<Union<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSetControl, BaseFunction>>, BaseFunction>? Controls { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessmentframework-controlset.html#cfn-auditmanager-assessmentframework-controlset-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
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
            public Union<string, BaseFunction>? Id { get; set; }
        }
    }
}