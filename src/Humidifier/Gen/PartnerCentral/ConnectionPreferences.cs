namespace Humidifier.PartnerCentral
{
    using global::System.Collections.Generic;

    public class ConnectionPreferences : Humidifier.Base.BaseResource, IHaveCatalog
    {
        public class Attributes
        {
            public static string Revision =  "Revision" ;
            public static string ExcludedParticipantIds =  "ExcludedParticipantIds" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string AccessType =  "AccessType" ;
        }

        public override string AWSTypeName { get => AWS.PartnerCentral.ConnectionPreferences; }
        /// <summary>
        /// Catalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-partnercentral-connectionpreferences.html#cfn-partnercentral-connectionpreferences-catalog
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Catalog { get; set; }
    }
}