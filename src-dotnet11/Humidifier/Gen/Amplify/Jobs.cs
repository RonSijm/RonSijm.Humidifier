namespace Humidifier.Amplify
{
    using global::System.Collections.Generic;

    public class Jobs : Humidifier.Base.BaseResource, IHaveAppId, IHaveBranchName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CommitId =  "CommitId" ;
            public static string CommitTime =  "CommitTime" ;
            public static string StartTime =  "StartTime" ;
            public static string Arn =  "Arn" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Amplify.Jobs; }

        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-jobs.html#cfn-amplify-jobs-appid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppId { get; set; }

        /// <summary>
        /// BranchName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-jobs.html#cfn-amplify-jobs-branchname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BranchName { get; set; }
    }
}