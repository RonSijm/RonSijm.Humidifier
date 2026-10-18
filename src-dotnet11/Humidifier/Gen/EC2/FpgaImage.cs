namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using FpgaImageTypes;

    public class FpgaImage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEC2FpgaImageTypesStorageLocationLogsStorageLocation, IHaveEC2FpgaImageTypesStorageLocationInputStorageLocation, IHaveDescription, IHaveName
    {
        public class Attributes
        {
            public static string FpgaImageId =  "FpgaImageId" ;
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string CreateTime =  "CreateTime" ;
            public static string DataRetentionSupport =  "DataRetentionSupport" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Public =  "Public" ;
            public static string Arn =  "Arn" ;
            public static string FpgaImageGlobalId =  "FpgaImageGlobalId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.FpgaImage; }
        /// <summary>
        /// LogsStorageLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fpgaimage.html#cfn-ec2-fpgaimage-logsstoragelocation
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StorageLocation
        /// </summary>
        public Union<Humidifier.EC2.FpgaImageTypes.StorageLocation, BaseFunction>? LogsStorageLocation { get; set; }
        /// <summary>
        /// InputStorageLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fpgaimage.html#cfn-ec2-fpgaimage-inputstoragelocation
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StorageLocation
        /// </summary>
        public Union<Humidifier.EC2.FpgaImageTypes.StorageLocation, BaseFunction>? InputStorageLocation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fpgaimage.html#cfn-ec2-fpgaimage-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fpgaimage.html#cfn-ec2-fpgaimage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FpgaImageTypes
    {
        public class StorageLocation : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fpgaimage-storagelocation.html#cfn-ec2-fpgaimage-storagelocation-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fpgaimage-storagelocation.html#cfn-ec2-fpgaimage-storagelocation-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}