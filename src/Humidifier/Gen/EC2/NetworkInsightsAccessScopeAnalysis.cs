namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class NetworkInsightsAccessScopeAnalysis : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StartDate =  "StartDate" ;
            public static string NetworkInsightsAccessScopeAnalysisId =  "NetworkInsightsAccessScopeAnalysisId" ;
            public static string NetworkInsightsAccessScopeAnalysisArn =  "NetworkInsightsAccessScopeAnalysisArn" ;
            public static string EndDate =  "EndDate" ;
            public static string AnalyzedEniCount =  "AnalyzedEniCount" ;
            public static string FindingsFound =  "FindingsFound" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInsightsAccessScopeAnalysis; }

        /// <summary>
        /// NetworkInsightsAccessScopeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscopeanalysis.html#cfn-ec2-networkinsightsaccessscopeanalysis-networkinsightsaccessscopeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkInsightsAccessScopeId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsaccessscopeanalysis.html#cfn-ec2-networkinsightsaccessscopeanalysis-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}