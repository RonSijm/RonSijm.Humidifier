namespace Humidifier.Batch
{
    using global::System.Collections.Generic;

    public class ConsumableResource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveResourceType
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
        public dynamic TotalQuantity { get; set; }
        public dynamic ConsumableResourceName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-consumableresource.html#cfn-batch-consumableresource-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-consumableresource.html#cfn-batch-consumableresource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}