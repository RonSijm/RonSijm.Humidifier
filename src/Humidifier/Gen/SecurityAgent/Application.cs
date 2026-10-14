namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn
    {
        public class Attributes
        {
            public static string ApplicationName =  "ApplicationName" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string Domain =  "Domain" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.Application; }
        /// <summary>
        /// IdCConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-application.html#cfn-securityagent-application-idcconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: IdCConfiguration
        /// </summary>
        public Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration IdCConfiguration { get; set; }
        /// <summary>
        /// DefaultKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-application.html#cfn-securityagent-application-defaultkmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultKmsKeyId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-application.html#cfn-securityagent-application-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-application.html#cfn-securityagent-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ApplicationTypes
    {
        public class IdCConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdCApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-application-idcconfiguration.html#cfn-securityagent-application-idcconfiguration-idcapplicationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdCApplicationArn { get; set; }
            /// <summary>
            /// IdCInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-application-idcconfiguration.html#cfn-securityagent-application-idcconfiguration-idcinstancearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdCInstanceArn { get; set; }
        }
    }
}