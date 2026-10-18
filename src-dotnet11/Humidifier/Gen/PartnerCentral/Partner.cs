namespace Humidifier.PartnerCentral
{
    using global::System.Collections.Generic;

    public class Partner : Humidifier.Base.BaseResource, IHaveTags, IHaveCatalog
    {
        public class Attributes
        {
            public static string LegalName =  "LegalName" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PrimarySolutionType =  "PrimarySolutionType" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PartnerCentral.Partner; }
        /// <summary>
        /// Catalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-partnercentral-partner.html#cfn-partnercentral-partner-catalog
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Catalog { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-partnercentral-partner.html#cfn-partnercentral-partner-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}