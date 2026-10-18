namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;

    public class TapePool : Humidifier.Base.BaseResource, IHaveTags, IHaveRetentionLockType, IHaveRetentionLockTimeInDays_Integer, IHavePoolName, IHaveStorageClass
    {
        public class Attributes
        {
            public static string PoolId =  "PoolId" ;
            public static string PoolARN =  "PoolARN" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.TapePool; }
        /// <summary>
        /// RetentionLockType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tapepool.html#cfn-storagegateway-tapepool-retentionlocktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RetentionLockType { get; set; }
        /// <summary>
        /// RetentionLockTimeInDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tapepool.html#cfn-storagegateway-tapepool-retentionlocktimeindays
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetentionLockTimeInDays { get; set; }

        /// <summary>
        /// PoolName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tapepool.html#cfn-storagegateway-tapepool-poolname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PoolName { get; set; }

        /// <summary>
        /// StorageClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tapepool.html#cfn-storagegateway-tapepool-storageclass
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StorageClass { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-tapepool.html#cfn-storagegateway-tapepool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}