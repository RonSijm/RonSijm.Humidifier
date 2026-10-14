namespace Humidifier.FMS
{
    using global::System.Collections.Generic;
    using ApplicationsListTypes;

    public class ApplicationsList : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ListId =  "ListId" ;
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.FMS.ApplicationsList; }

        /// <summary>
        /// ListName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-applicationslist.html#cfn-fms-applicationslist-listname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ListName { get; set; }

        /// <summary>
        /// AppsList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-applicationslist.html#cfn-fms-applicationslist-appslist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: App
        /// </summary>
        [Required]
        public List<Humidifier.FMS.ApplicationsListTypes.App> AppsList { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-applicationslist.html#cfn-fms-applicationslist-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ApplicationsListTypes
    {
        public class App : Humidifier.Base.BaseSubResource, IHavePort, IHaveProtocol
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-applicationslist-app.html#cfn-fms-applicationslist-app-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-applicationslist-app.html#cfn-fms-applicationslist-app-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// AppName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-applicationslist-app.html#cfn-fms-applicationslist-app-appname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppName { get; set; }
        }
    }
}