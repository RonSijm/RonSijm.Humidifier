namespace Humidifier.AppFabric
{
    using global::System.Collections.Generic;

    public class AppBundle : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppFabric.AppBundle; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appbundle.html#cfn-appfabric-appbundle-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// CustomerManagedKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-appbundle.html#cfn-appfabric-appbundle-customermanagedkeyidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerManagedKeyIdentifier { get; set; }
    }
}