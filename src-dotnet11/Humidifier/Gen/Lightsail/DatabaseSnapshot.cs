namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using DatabaseSnapshotTypes;

    public class DatabaseSnapshot : Humidifier.Base.BaseResource, IHaveTags, IHaveRelationalDatabaseName, IHaveRelationalDatabaseSnapshotName
    {
        public class Attributes
        {
            public static string EngineVersion =  "EngineVersion" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ResourceType =  "ResourceType" ;
            public static string FromRelationalDatabaseBlueprintId =  "FromRelationalDatabaseBlueprintId" ;
            public static string Name =  "Name" ;
            public static string SizeInGb =  "SizeInGb" ;
            public static string FromRelationalDatabaseArn =  "FromRelationalDatabaseArn" ;
            public static string SupportCode =  "SupportCode" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string FromRelationalDatabaseBundleId =  "FromRelationalDatabaseBundleId" ;
            public static string Engine =  "Engine" ;
            public static string FromRelationalDatabaseName =  "FromRelationalDatabaseName" ;
            public static string Location =  "Location" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.DatabaseSnapshot; }

        /// <summary>
        /// RelationalDatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-databasesnapshot.html#cfn-lightsail-databasesnapshot-relationaldatabasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RelationalDatabaseName { get; set; }

        /// <summary>
        /// RelationalDatabaseSnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-databasesnapshot.html#cfn-lightsail-databasesnapshot-relationaldatabasesnapshotname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RelationalDatabaseSnapshotName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-databasesnapshot.html#cfn-lightsail-databasesnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DatabaseSnapshotTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-databasesnapshot-location.html#cfn-lightsail-databasesnapshot-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-databasesnapshot-location.html#cfn-lightsail-databasesnapshot-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}