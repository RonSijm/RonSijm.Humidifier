namespace Humidifier.ServiceCatalogAppRegistry
{
    using global::System.Collections.Generic;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string ApplicationName =  "ApplicationName" ;
            public static string ApplicationTagKey =  "ApplicationTagKey" ;
            public static string ApplicationTagValue =  "ApplicationTagValue" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ServiceCatalogAppRegistry.Application; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-application.html#cfn-servicecatalogappregistry-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-application.html#cfn-servicecatalogappregistry-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}