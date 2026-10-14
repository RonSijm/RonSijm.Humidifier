namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;

    public class Build : Humidifier.Base.BaseResource, IHaveProjectName
    {
        public class Attributes
        {
            public static string CurrentPhase =  "CurrentPhase" ;
            public static string EndTime =  "EndTime" ;
            public static string StartTime =  "StartTime" ;
            public static string EncryptionKey =  "EncryptionKey" ;
            public static string BuildNumber =  "BuildNumber" ;
            public static string ServiceRole =  "ServiceRole" ;
            public static string QueuedTimeoutInMinutes =  "QueuedTimeoutInMinutes" ;
            public static string Initiator =  "Initiator" ;
            public static string BuildStatus =  "BuildStatus" ;
            public static string Id =  "Id" ;
            public static string BuildComplete =  "BuildComplete" ;
            public static string Arn =  "Arn" ;
            public static string TimeoutInMinutes =  "TimeoutInMinutes" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.Build; }
        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-build.html#cfn-codebuild-build-projectname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectName { get; set; }
    }
}