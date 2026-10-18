namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;

    public class DomainUnit : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveParentDomainUnitIdentifier, IHaveDomainIdentifier, IHaveName
    {
        public class Attributes
        {
            public static string DomainId =  "DomainId" ;
            public static string Identifier =  "Identifier" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string ParentDomainUnitId =  "ParentDomainUnitId" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.DomainUnit; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domainunit.html#cfn-datazone-domainunit-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ParentDomainUnitIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domainunit.html#cfn-datazone-domainunit-parentdomainunitidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ParentDomainUnitIdentifier { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domainunit.html#cfn-datazone-domainunit-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}