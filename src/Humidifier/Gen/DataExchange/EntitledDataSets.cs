namespace Humidifier.DataExchange
{
    using global::System.Collections.Generic;

    public class EntitledDataSets : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string Origin =  "Origin" ;
            public static string SourceId =  "SourceId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string DataSetId =  "DataSetId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DataExchange.EntitledDataSets; }
        /// <summary>
        /// AssetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-entitleddatasets.html#cfn-dataexchange-entitleddatasets-assettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AssetType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-entitleddatasets.html#cfn-dataexchange-entitleddatasets-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}