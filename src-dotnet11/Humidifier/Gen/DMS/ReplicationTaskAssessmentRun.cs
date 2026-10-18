namespace Humidifier.DMS
{
    using global::System.Collections.Generic;
    using ReplicationTaskAssessmentRunTypes;

    public class ReplicationTaskAssessmentRun : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ReplicationTaskAssessmentRunCreationDate =  "ReplicationTaskAssessmentRunCreationDate" ;
            public static string AssessmentProgress =  "AssessmentProgress" ;
            public static string ResultLocationBucket =  "ResultLocationBucket" ;
            public static string ResultEncryptionMode =  "ResultEncryptionMode" ;
            public static string IsLatestTaskAssessmentRun =  "IsLatestTaskAssessmentRun" ;
            public static string AssessmentRunName =  "AssessmentRunName" ;
            public static string ReplicationTaskArn =  "ReplicationTaskArn" ;
            public static string ReplicationTaskAssessmentRunArn =  "ReplicationTaskAssessmentRunArn" ;
            public static string ServiceAccessRoleArn =  "ServiceAccessRoleArn" ;
            public static string ResultLocationFolder =  "ResultLocationFolder" ;
        }

        public override string AWSTypeName { get => AWS.DMS.ReplicationTaskAssessmentRun; }
    }

    namespace ReplicationTaskAssessmentRunTypes
    {
        public class AssessmentProgress : Humidifier.Base.BaseSubResource, IHaveIndividualAssessmentCompletedCount_Integer, IHaveIndividualAssessmentCount_Integer
        {
            /// <summary>
            /// IndividualAssessmentCompletedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationtaskassessmentrun-assessmentprogress.html#cfn-dms-replicationtaskassessmentrun-assessmentprogress-individualassessmentcompletedcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IndividualAssessmentCompletedCount { get; set; }
            /// <summary>
            /// IndividualAssessmentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationtaskassessmentrun-assessmentprogress.html#cfn-dms-replicationtaskassessmentrun-assessmentprogress-individualassessmentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IndividualAssessmentCount { get; set; }
        }
    }
}