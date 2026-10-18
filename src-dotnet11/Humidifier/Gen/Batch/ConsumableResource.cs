namespace Humidifier.Batch
{
    using global::System.Collections.Generic;

    public class ConsumableResource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTotalQuantity_Long, IHaveConsumableResourceName, IHaveResourceType, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConsumableResourceArn =  "ConsumableResourceArn" ;
            public static string InUseQuantity =  "InUseQuantity" ;
            public static string AvailableQuantity =  "AvailableQuantity" ;
        }

        public override string AWSTypeName { get => AWS.Batch.ConsumableResource; }

        /// <summary>
        /// TotalQuantity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-consumableresource.html#cfn-batch-consumableresource-totalquantity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Long
        /// </summary>
        [Required]
        public Union<long, BaseFunction>? TotalQuantity { get; set; }
        public Union<string, BaseFunction>? ConsumableResourceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-consumableresource.html#cfn-batch-consumableresource-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-consumableresource.html#cfn-batch-consumableresource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}