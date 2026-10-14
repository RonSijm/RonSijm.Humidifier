namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class HubContentVersion : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string SageMakerPublicHubContentArn =  "SageMakerPublicHubContentArn" ;
            public static string DocumentSchemaVersion =  "DocumentSchemaVersion" ;
            public static string HubContentVersion =  "HubContentVersion" ;
            public static string HubContentStatus =  "HubContentStatus" ;
            public static string HubContentDisplayName =  "HubContentDisplayName" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string SupportStatus =  "SupportStatus" ;
            public static string HubArn =  "HubArn" ;
            public static string HubContentArn =  "HubContentArn" ;
            public static string ReferenceMinVersion =  "ReferenceMinVersion" ;
            public static string HubContentDescription =  "HubContentDescription" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.HubContentVersion; }
        /// <summary>
        /// HubName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hubcontentversion.html#cfn-sagemaker-hubcontentversion-hubname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HubName { get; set; }
        /// <summary>
        /// HubContentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hubcontentversion.html#cfn-sagemaker-hubcontentversion-hubcontenttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HubContentType { get; set; }
        /// <summary>
        /// HubContentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hubcontentversion.html#cfn-sagemaker-hubcontentversion-hubcontentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HubContentName { get; set; }
    }
}