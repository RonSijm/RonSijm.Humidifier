namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainName, IHaveListOfLightsailDomainTypesDomainEntryDomainEntries
    {
        public class Attributes
        {
            public static string SupportCode =  "SupportCode" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Arn =  "Arn" ;
            public static string Location =  "Location" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Domain; }
        public Union<string, BaseFunction>? DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DomainEntries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-domain.html#cfn-lightsail-domain-domainentries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DomainEntry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lightsail.DomainTypes.DomainEntry>, IReadOnlyList<Union<Humidifier.Lightsail.DomainTypes.DomainEntry, BaseFunction>>, BaseFunction>? DomainEntries { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-domain.html#cfn-lightsail-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DomainTypes
    {
        public class DomainEntry : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveType, IHaveId, IHaveIsAlias_Boolean, IHaveName
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-domainentry.html#cfn-lightsail-domain-domainentry-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-domainentry.html#cfn-lightsail-domain-domainentry-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-domainentry.html#cfn-lightsail-domain-domainentry-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// IsAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-domainentry.html#cfn-lightsail-domain-domainentry-isalias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsAlias { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-domainentry.html#cfn-lightsail-domain-domainentry-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-location.html#cfn-lightsail-domain-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-domain-location.html#cfn-lightsail-domain-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}