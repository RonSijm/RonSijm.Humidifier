namespace Humidifier.UserNotifications
{
    using global::System.Collections.Generic;

    public class ManagedNotificationConfiguration : Humidifier.Base.BaseResource, IHaveCategory, IHaveSubCategory
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.UserNotifications.ManagedNotificationConfiguration; }
        /// <summary>
        /// Category
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-usernotifications-managednotificationconfiguration.html#cfn-usernotifications-managednotificationconfiguration-category
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Category { get; set; }
        /// <summary>
        /// SubCategory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-usernotifications-managednotificationconfiguration.html#cfn-usernotifications-managednotificationconfiguration-subcategory
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubCategory { get; set; }
    }
}