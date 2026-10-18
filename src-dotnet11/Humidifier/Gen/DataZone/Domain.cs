namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainExecutionRole, IHaveKmsKeyIdentifier, IHaveDescription, IHaveServiceRole, IHaveDomainVersion, IHaveName, IHaveDataZoneDomainTypesSingleSignOnSingleSignOn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string RootDomainUnitId =  "RootDomainUnitId" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string PortalUrl =  "PortalUrl" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string ManagedAccountId =  "ManagedAccountId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.Domain; }
        /// <summary>
        /// DomainExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-domainexecutionrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainExecutionRole { get; set; }
        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-kmskeyidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-servicerole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceRole { get; set; }
        /// <summary>
        /// DomainVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-domainversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SingleSignOn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-domain.html#cfn-datazone-domain-singlesignon
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SingleSignOn
        /// </summary>
        public Union<Humidifier.DataZone.DomainTypes.SingleSignOn, BaseFunction>? SingleSignOn { get; set; }
    }

    namespace DomainTypes
    {
        public class SingleSignOn : Humidifier.Base.BaseSubResource, IHaveType, IHaveUserAssignment, IHaveIdcInstanceArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-domain-singlesignon.html#cfn-datazone-domain-singlesignon-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// UserAssignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-domain-singlesignon.html#cfn-datazone-domain-singlesignon-userassignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAssignment { get; set; }
            /// <summary>
            /// IdcInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-domain-singlesignon.html#cfn-datazone-domain-singlesignon-idcinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdcInstanceArn { get; set; }
        }
    }
}