namespace Humidifier.HealthImaging
{
    using System.Collections.Generic;

    public class Datastore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveKmsKeyArn, IHaveDatastoreName
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
        public dynamic KmsKeyArn { get; set; }
        public dynamic DatastoreName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthimaging-datastore.html#cfn-healthimaging-datastore-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}