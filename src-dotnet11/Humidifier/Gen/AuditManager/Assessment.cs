namespace Humidifier.AuditManager
{
    using global::System.Collections.Generic;
    using AssessmentTypes;

    public class Assessment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveAuditManagerAssessmentTypesAssessmentReportsDestinationAssessmentReportsDestination, IHaveListOfAuditManagerAssessmentTypesDelegationDelegations, IHaveDescription, IHaveAuditManagerAssessmentTypesScopeScope, IHaveAuditManagerAssessmentTypesAWSAccountAwsAccount, IHaveListOfAuditManagerAssessmentTypesRoleRoles, IHaveFrameworkId, IHaveName
    {
        public class Attributes
        {
            public static string AssessmentId =  "AssessmentId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AuditManager.Assessment; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// AssessmentReportsDestination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-assessmentreportsdestination
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AssessmentReportsDestination
        /// </summary>
        public Union<Humidifier.AuditManager.AssessmentTypes.AssessmentReportsDestination, BaseFunction>? AssessmentReportsDestination { get; set; }
        /// <summary>
        /// Delegations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-delegations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Delegation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AuditManager.AssessmentTypes.Delegation>, IReadOnlyList<Union<Humidifier.AuditManager.AssessmentTypes.Delegation, BaseFunction>>, BaseFunction>? Delegations { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-scope
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Scope
        /// </summary>
        public Union<Humidifier.AuditManager.AssessmentTypes.Scope, BaseFunction>? Scope { get; set; }
        /// <summary>
        /// AwsAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-awsaccount
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AWSAccount
        /// </summary>
        public Union<Humidifier.AuditManager.AssessmentTypes.AWSAccount, BaseFunction>? AwsAccount { get; set; }
        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-roles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Role
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AuditManager.AssessmentTypes.Role>, IReadOnlyList<Union<Humidifier.AuditManager.AssessmentTypes.Role, BaseFunction>>, BaseFunction>? Roles { get; set; }
        /// <summary>
        /// FrameworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-frameworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FrameworkId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html#cfn-auditmanager-assessment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AssessmentTypes
    {
        public class AWSAccount : Humidifier.Base.BaseSubResource, IHaveEmailAddress, IHaveId, IHaveName
        {
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsaccount.html#cfn-auditmanager-assessment-awsaccount-emailaddress
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailAddress { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsaccount.html#cfn-auditmanager-assessment-awsaccount-id
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsaccount.html#cfn-auditmanager-assessment-awsaccount-name
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AWSService : Humidifier.Base.BaseSubResource, IHaveServiceName
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsservice.html#cfn-auditmanager-assessment-awsservice-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
        }

        public class AssessmentReportsDestination : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveDestinationType
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-assessmentreportsdestination.html#cfn-auditmanager-assessment-assessmentreportsdestination-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// DestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-assessmentreportsdestination.html#cfn-auditmanager-assessment-assessmentreportsdestination-destinationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationType { get; set; }
        }

        public class Delegation : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveComment, IHaveCreatedBy, IHaveRoleType, IHaveAssessmentId, IHaveCreationTime_Double, IHaveLastUpdated_Double, IHaveId, IHaveAssessmentName, IHaveRoleArn, IHaveControlSetId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// CreatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-createdby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedBy { get; set; }
            /// <summary>
            /// RoleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-roletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleType { get; set; }
            /// <summary>
            /// AssessmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-assessmentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssessmentId { get; set; }
            /// <summary>
            /// CreationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-creationtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CreationTime { get; set; }
            /// <summary>
            /// LastUpdated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-lastupdated
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LastUpdated { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// AssessmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-assessmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssessmentName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// ControlSetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html#cfn-auditmanager-assessment-delegation-controlsetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ControlSetId { get; set; }
        }

        public class Role : Humidifier.Base.BaseSubResource, IHaveRoleType, IHaveRoleArn
        {
            /// <summary>
            /// RoleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-role.html#cfn-auditmanager-assessment-role-roletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleType { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-role.html#cfn-auditmanager-assessment-role-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class Scope : Humidifier.Base.BaseSubResource, IHaveListOfAuditManagerAssessmentTypesAWSAccountAwsAccounts, IHaveListOfAuditManagerAssessmentTypesAWSServiceAwsServices
        {
            /// <summary>
            /// AwsAccounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-scope.html#cfn-auditmanager-assessment-scope-awsaccounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AWSAccount
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AuditManager.AssessmentTypes.AWSAccount>, IReadOnlyList<Union<Humidifier.AuditManager.AssessmentTypes.AWSAccount, BaseFunction>>, BaseFunction>? AwsAccounts { get; set; }
            /// <summary>
            /// AwsServices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-scope.html#cfn-auditmanager-assessment-scope-awsservices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AWSService
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AuditManager.AssessmentTypes.AWSService>, IReadOnlyList<Union<Humidifier.AuditManager.AssessmentTypes.AWSService, BaseFunction>>, BaseFunction>? AwsServices { get; set; }
        }
    }
}