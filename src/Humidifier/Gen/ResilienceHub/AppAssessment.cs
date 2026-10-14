namespace Humidifier.ResilienceHub
{
    using global::System.Collections.Generic;
    using AppAssessmentTypes;

    public class AppAssessment : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Policy =  "Policy" ;
            public static string EndTime =  "EndTime" ;
            public static string Compliance =  "Compliance" ;
            public static string ComplianceStatus =  "ComplianceStatus" ;
            public static string StartTime =  "StartTime" ;
            public static string AssessmentArn =  "AssessmentArn" ;
            public static string Cost =  "Cost" ;
            public static string ResiliencyScore =  "ResiliencyScore" ;
            public static string AppVersion =  "AppVersion" ;
            public static string Invoker =  "Invoker" ;
            public static string AssessmentStatus =  "AssessmentStatus" ;
            public static string DriftStatus =  "DriftStatus" ;
            public static string VersionName =  "VersionName" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHub.AppAssessment; }

        /// <summary>
        /// AppArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-appassessment.html#cfn-resiliencehub-appassessment-apparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppArn { get; set; }

        /// <summary>
        /// AssessmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-appassessment.html#cfn-resiliencehub-appassessment-assessmentname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssessmentName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-appassessment.html#cfn-resiliencehub-appassessment-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace AppAssessmentTypes
    {
        public class Cost : Humidifier.Base.BaseSubResource, IHaveFrequency, IHaveAmount
        {
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-cost.html#cfn-resiliencehub-appassessment-cost-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Amount { get; set; }
            /// <summary>
            /// Currency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-cost.html#cfn-resiliencehub-appassessment-cost-currency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Currency { get; set; }
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-cost.html#cfn-resiliencehub-appassessment-cost-frequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Frequency { get; set; }
        }

        public class DisruptionCompliance : Humidifier.Base.BaseSubResource, IHaveMessage
        {
            /// <summary>
            /// RtoDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-rtodescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RtoDescription { get; set; }
            /// <summary>
            /// CurrentRpoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-currentrpoinsecs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CurrentRpoInSecs { get; set; }
            /// <summary>
            /// RpoReferenceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-rporeferenceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RpoReferenceId { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// ComplianceStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-compliancestatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComplianceStatus { get; set; }
            /// <summary>
            /// RpoDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-rpodescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RpoDescription { get; set; }
            /// <summary>
            /// CurrentRtoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-currentrtoinsecs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CurrentRtoInSecs { get; set; }
            /// <summary>
            /// RtoReferenceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-rtoreferenceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RtoReferenceId { get; set; }
            /// <summary>
            /// AchievableRtoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-achievablertoinsecs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic AchievableRtoInSecs { get; set; }
            /// <summary>
            /// AchievableRpoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-disruptioncompliance.html#cfn-resiliencehub-appassessment-disruptioncompliance-achievablerpoinsecs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic AchievableRpoInSecs { get; set; }
        }

        public class FailurePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RpoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-failurepolicy.html#cfn-resiliencehub-appassessment-failurepolicy-rpoinsecs
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RpoInSecs { get; set; }
            /// <summary>
            /// RtoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-failurepolicy.html#cfn-resiliencehub-appassessment-failurepolicy-rtoinsecs
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RtoInSecs { get; set; }
        }

        public class ResiliencyPolicy : Humidifier.Base.BaseSubResource, IHavePolicyName, IHavePolicyArn
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencypolicy.html#cfn-resiliencehub-appassessment-resiliencypolicy-policy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: FailurePolicy
            /// </summary>
            public Dictionary<string, Humidifier.ResilienceHub.AppAssessmentTypes.FailurePolicy> Policy { get; set; }
            /// <summary>
            /// PolicyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencypolicy.html#cfn-resiliencehub-appassessment-resiliencypolicy-policyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyArn { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencypolicy.html#cfn-resiliencehub-appassessment-resiliencypolicy-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyName { get; set; }
            /// <summary>
            /// DataLocationConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencypolicy.html#cfn-resiliencehub-appassessment-resiliencypolicy-datalocationconstraint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataLocationConstraint { get; set; }
        }

        public class ResiliencyScore : Humidifier.Base.BaseSubResource, IHaveScore
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencyscore.html#cfn-resiliencehub-appassessment-resiliencyscore-score
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Score { get; set; }
            /// <summary>
            /// ComponentScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencyscore.html#cfn-resiliencehub-appassessment-resiliencyscore-componentscore
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ScoringComponentResiliencyScore
            /// </summary>
            public Dictionary<string, Humidifier.ResilienceHub.AppAssessmentTypes.ScoringComponentResiliencyScore> ComponentScore { get; set; }
            /// <summary>
            /// DisruptionScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-resiliencyscore.html#cfn-resiliencehub-appassessment-resiliencyscore-disruptionscore
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: Double
            /// </summary>
            public Dictionary<string, double> DisruptionScore { get; set; }
        }

        public class ScoringComponentResiliencyScore : Humidifier.Base.BaseSubResource, IHaveScore
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-scoringcomponentresiliencyscore.html#cfn-resiliencehub-appassessment-scoringcomponentresiliencyscore-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Score { get; set; }
            /// <summary>
            /// OutstandingCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-scoringcomponentresiliencyscore.html#cfn-resiliencehub-appassessment-scoringcomponentresiliencyscore-outstandingcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic OutstandingCount { get; set; }
            /// <summary>
            /// PossibleScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-scoringcomponentresiliencyscore.html#cfn-resiliencehub-appassessment-scoringcomponentresiliencyscore-possiblescore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PossibleScore { get; set; }
            /// <summary>
            /// ExcludedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-appassessment-scoringcomponentresiliencyscore.html#cfn-resiliencehub-appassessment-scoringcomponentresiliencyscore-excludedcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ExcludedCount { get; set; }
        }
    }
}