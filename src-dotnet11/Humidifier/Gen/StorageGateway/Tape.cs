namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;

    public class Tape : Humidifier.Base.BaseResource, IHaveTags, IHaveGatewayARN, IHaveKMSKey, IHaveTapeBarcode, IHaveTapeSizeInBytes_Double, IHaveKMSEncrypted_Boolean, IHavePoolId, IHaveWorm_Boolean
    {
        public class Attributes
        {
            public static string TapeARN =  "TapeARN" ;
            public static string TapeCreatedDate =  "TapeCreatedDate" ;
            public static string TapeStatus =  "TapeStatus" ;
            public static string TapeUsedInBytes =  "TapeUsedInBytes" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.Tape; }

        /// <summary>
        /// GatewayARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-gatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayARN { get; set; }
        /// <summary>
        /// KMSKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-kmskey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKey { get; set; }
        /// <summary>
        /// TapeBarcode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-tapebarcode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TapeBarcode { get; set; }

        /// <summary>
        /// TapeSizeInBytes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-tapesizeinbytes
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? TapeSizeInBytes { get; set; }
        /// <summary>
        /// KMSEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-kmsencrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? KMSEncrypted { get; set; }
        /// <summary>
        /// PoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-poolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PoolId { get; set; }
        /// <summary>
        /// Worm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-worm
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Worm { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tape.html#cfn-storagegateway-tape-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}