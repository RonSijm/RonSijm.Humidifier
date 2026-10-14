namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;

    public class BuildBatch : Humidifier.Base.BaseResource, IHaveProjectName
    {
        public class Attributes
        {
            public static string CurrentPhase =  "CurrentPhase" ;
            public static string BuildTimeoutInMinutes =  "BuildTimeoutInMinutes" ;
            public static string QueuedTimeoutInMinutes =  "QueuedTimeoutInMinutes" ;
            public static string Initiator =  "Initiator" ;
            public static string Complete =  "Complete" ;
            public static string StartTime =  "StartTime" ;
            public static string BuildBatchNumber =  "BuildBatchNumber" ;
            public static string EncryptionKey =  "EncryptionKey" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string BuildBatchStatus =  "BuildBatchStatus" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.BuildBatch; }
        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-buildbatch.html#cfn-codebuild-buildbatch-projectname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectName { get; set; }
    }
}