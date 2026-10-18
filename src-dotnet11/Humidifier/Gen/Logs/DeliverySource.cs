namespace Humidifier.Logs
{
    using global::System.Collections.Generic;

    public class DeliverySource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResourceArn, IHaveLogType, IHaveName, IHaveStringDictionaryOfDeliverySourceConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StatusReason =  "StatusReason" ;
            public static string Service =  "Service" ;
            public static string Arn =  "Arn" ;
            public static string ResourceArns =  "ResourceArns" ;
        }

        public override string AWSTypeName { get => AWS.Logs.DeliverySource; }
        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverysource.html#cfn-logs-deliverysource-resourcearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceArn { get; set; }
        /// <summary>
        /// LogType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverysource.html#cfn-logs-deliverysource-logtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverysource.html#cfn-logs-deliverysource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeliverySourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverysource.html#cfn-logs-deliverysource-deliverysourceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DeliverySourceConfiguration { get; set; }
    }
}