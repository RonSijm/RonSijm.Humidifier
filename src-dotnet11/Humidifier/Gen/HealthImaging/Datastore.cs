namespace Humidifier.HealthImaging
{
    using global::System.Collections.Generic;

    public class Datastore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveKmsKeyArn, IHaveDatastoreName, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string DatastoreArn =  "DatastoreArn" ;
            public static string DatastoreId =  "DatastoreId" ;
            public static string DatastoreStatus =  "DatastoreStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.HealthImaging.Datastore; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthimaging-datastore.html#cfn-healthimaging-datastore-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        public Union<string, BaseFunction>? DatastoreName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthimaging-datastore.html#cfn-healthimaging-datastore-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}