namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;

    public class ExtensionAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveResourceIdentifier, IHaveStringDictionaryOfParameters, IHaveExtensionIdentifier, IHaveExtensionVersionNumber_Integer
    {
        public class Attributes
        {
            public static string ResourceArn =  "ResourceArn" ;
            public static string ExtensionArn =  "ExtensionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppConfig.ExtensionAssociation; }
        /// <summary>
        /// ResourceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extensionassociation.html#cfn-appconfig-extensionassociation-resourceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceIdentifier { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extensionassociation.html#cfn-appconfig-extensionassociation-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// ExtensionIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extensionassociation.html#cfn-appconfig-extensionassociation-extensionidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExtensionIdentifier { get; set; }
        /// <summary>
        /// ExtensionVersionNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extensionassociation.html#cfn-appconfig-extensionassociation-extensionversionnumber
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ExtensionVersionNumber { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extensionassociation.html#cfn-appconfig-extensionassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}