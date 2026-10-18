namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using AssociationTypes;

    public class Association : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAssociationName, IHaveStringListOfCalendarNames, IHaveScheduleExpression, IHaveMaxErrors, IHaveParameters_Json, IHaveInstanceId, IHaveAssociationDispatchAssumeRole, IHaveWaitForSuccessTimeoutSeconds_Integer, IHaveMaxConcurrency, IHaveComplianceSeverity, IHaveListOfSSMAssociationTypesTargetTargets, IHaveSyncCompliance, IHaveSSMAssociationTypesInstanceAssociationOutputLocationOutputLocation, IHaveScheduleOffset_Integer, IHaveName, IHaveApplyOnlyAtCronInterval_Boolean, IHaveDocumentVersion, IHaveAutomationTargetParameterName
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.SSM.Association; }
        public Union<string, BaseFunction>? AssociationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CalendarNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-calendarnames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CalendarNames { get; set; }
        /// <summary>
        /// ScheduleExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-scheduleexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScheduleExpression { get; set; }
        /// <summary>
        /// MaxErrors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-maxerrors
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MaxErrors { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceId { get; set; }
        /// <summary>
        /// AssociationDispatchAssumeRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-associationdispatchassumerole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssociationDispatchAssumeRole { get; set; }
        /// <summary>
        /// WaitForSuccessTimeoutSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-waitforsuccesstimeoutseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? WaitForSuccessTimeoutSeconds { get; set; }
        /// <summary>
        /// MaxConcurrency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-maxconcurrency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MaxConcurrency { get; set; }
        /// <summary>
        /// ComplianceSeverity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-complianceseverity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComplianceSeverity { get; set; }
        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-targets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Target
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSM.AssociationTypes.Target>, IReadOnlyList<Union<Humidifier.SSM.AssociationTypes.Target, BaseFunction>>, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// SyncCompliance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-synccompliance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SyncCompliance { get; set; }
        /// <summary>
        /// OutputLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-outputlocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceAssociationOutputLocation
        /// </summary>
        public Union<Humidifier.SSM.AssociationTypes.InstanceAssociationOutputLocation, BaseFunction>? OutputLocation { get; set; }
        /// <summary>
        /// ScheduleOffset
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-scheduleoffset
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ScheduleOffset { get; set; }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Name { get; set; }
        /// <summary>
        /// ApplyOnlyAtCronInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-applyonlyatcroninterval
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ApplyOnlyAtCronInterval { get; set; }
        /// <summary>
        /// DocumentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-documentversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DocumentVersion { get; set; }
        /// <summary>
        /// AutomationTargetParameterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-automationtargetparametername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutomationTargetParameterName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html#cfn-ssm-association-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AssociationTypes
    {
        public class InstanceAssociationOutputLocation : Humidifier.Base.BaseSubResource, IHaveSSMAssociationTypesS3OutputLocationS3Location
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-instanceassociationoutputlocation.html#cfn-ssm-association-instanceassociationoutputlocation-s3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3OutputLocation
            /// </summary>
            public Union<Humidifier.SSM.AssociationTypes.S3OutputLocation, BaseFunction>? S3Location { get; set; }
        }

        public class S3OutputLocation : Humidifier.Base.BaseSubResource, IHaveOutputS3KeyPrefix, IHaveOutputS3Region, IHaveOutputS3BucketName
        {
            /// <summary>
            /// OutputS3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html#cfn-ssm-association-s3outputlocation-outputs3keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3KeyPrefix { get; set; }
            /// <summary>
            /// OutputS3Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html#cfn-ssm-association-s3outputlocation-outputs3region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3Region { get; set; }
            /// <summary>
            /// OutputS3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html#cfn-ssm-association-s3outputlocation-outputs3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3BucketName { get; set; }
        }

        public class Target : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-target.html#cfn-ssm-association-target-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-target.html#cfn-ssm-association-target-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}