namespace Humidifier.ManagedBlockchain
{
    using global::System.Collections.Generic;

    public class Accessor : Humidifier.Base.BaseResource, IHaveTags, IHaveNetworkType, IHaveAccessorType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDate =  "CreationDate" ;
            public static string BillingToken =  "BillingToken" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ManagedBlockchain.Accessor; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-accessor.html#cfn-managedblockchain-accessor-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-accessor.html#cfn-managedblockchain-accessor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AccessorType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-accessor.html#cfn-managedblockchain-accessor-accessortype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessorType { get; set; }
    }
}