namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;

    public class Sandbox : Humidifier.Base.BaseResource, IHaveProjectName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ServiceRole =  "ServiceRole" ;
            public static string QueuedTimeoutInMinutes =  "QueuedTimeoutInMinutes" ;
            public static string StartTime =  "StartTime" ;
            public static string RequestTime =  "RequestTime" ;
            public static string EncryptionKey =  "EncryptionKey" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string TimeoutInMinutes =  "TimeoutInMinutes" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.Sandbox; }
        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sandbox.html#cfn-codebuild-sandbox-projectname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectName { get; set; }
    }
}