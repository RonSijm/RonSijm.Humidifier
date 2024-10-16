namespace Humidifier.IoTFleetHub
{
    using System.Collections.Generic;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleArn, IHaveApplicationName, IHaveApplicationDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string ApplicationUrl =  "ApplicationUrl" ;
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string ApplicationState =  "ApplicationState" ;
            public static string SsoClientId =  "SsoClientId" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string ApplicationLastUpdateDate =  "ApplicationLastUpdateDate" ;
            public static string ErrorMessage =  "ErrorMessage" ;
            public static string ApplicationCreationDate =  "ApplicationCreationDate" ;
        }

        public override string AWSTypeName { get => AWS.IoTFleetHub.Application; }
        public dynamic ApplicationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ApplicationDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleethub-application.html#cfn-iotfleethub-application-applicationdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ApplicationDescription; set => ApplicationDescription = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleethub-application.html#cfn-iotfleethub-application-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleethub-application.html#cfn-iotfleethub-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}