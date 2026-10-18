namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;
    using RedshiftIdcApplicationTypes;

    public class RedshiftIdcApplication : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRedshiftIdcApplicationName, IHaveIdcDisplayName, IHaveApplicationType, IHaveListOfRedshiftRedshiftIdcApplicationTypesAuthorizedTokenIssuerAuthorizedTokenIssuerList, IHaveIamRoleArn, IHaveListOfRedshiftRedshiftIdcApplicationTypesServiceIntegrationsUnionServiceIntegrations, IHaveIdentityNamespace, IHaveStringListOfSsoTagKeys, IHaveIdcInstanceArn
    {
        public class Attributes
        {
            public static string IdcOnboardStatus =  "IdcOnboardStatus" ;
            public static string IdcManagedApplicationArn =  "IdcManagedApplicationArn" ;
            public static string RedshiftIdcApplicationArn =  "RedshiftIdcApplicationArn" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.RedshiftIdcApplication; }
        public Union<string, BaseFunction>? RedshiftIdcApplicationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// IdcDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-idcdisplayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdcDisplayName { get; set; }
        /// <summary>
        /// ApplicationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-applicationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationType { get; set; }
        /// <summary>
        /// AuthorizedTokenIssuerList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-authorizedtokenissuerlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AuthorizedTokenIssuer
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer>, IReadOnlyList<Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer, BaseFunction>>, BaseFunction>? AuthorizedTokenIssuerList { get; set; }

        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-iamrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IamRoleArn { get; set; }
        /// <summary>
        /// ServiceIntegrations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-serviceintegrations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ServiceIntegrationsUnion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion>, IReadOnlyList<Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion, BaseFunction>>, BaseFunction>? ServiceIntegrations { get; set; }
        /// <summary>
        /// IdentityNamespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-identitynamespace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityNamespace { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SsoTagKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-ssotagkeys
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SsoTagKeys { get; set; }

        /// <summary>
        /// IdcInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-idcinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdcInstanceArn { get; set; }
    }

    namespace RedshiftIdcApplicationTypes
    {
        public class AuthorizedTokenIssuer : Humidifier.Base.BaseSubResource, IHaveTrustedTokenIssuerArn, IHaveStringListOfAuthorizedAudiencesList
        {
            /// <summary>
            /// TrustedTokenIssuerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-authorizedtokenissuer.html#cfn-redshift-redshiftidcapplication-authorizedtokenissuer-trustedtokenissuerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustedTokenIssuerArn { get; set; }
            /// <summary>
            /// AuthorizedAudiencesList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-authorizedtokenissuer.html#cfn-redshift-redshiftidcapplication-authorizedtokenissuer-authorizedaudienceslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthorizedAudiencesList { get; set; }
        }

        public class Connect : Humidifier.Base.BaseSubResource, IHaveAuthorization
        {
            /// <summary>
            /// Authorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-connect.html#cfn-redshift-redshiftidcapplication-connect-authorization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Authorization { get; set; }
        }

        public class LakeFormationQuery : Humidifier.Base.BaseSubResource, IHaveAuthorization
        {
            /// <summary>
            /// Authorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-lakeformationquery.html#cfn-redshift-redshiftidcapplication-lakeformationquery-authorization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Authorization { get; set; }
        }

        public class LakeFormationScopeUnion : Humidifier.Base.BaseSubResource, IHaveRedshiftRedshiftIdcApplicationTypesLakeFormationQueryLakeFormationQuery
        {
            /// <summary>
            /// LakeFormationQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-lakeformationscopeunion.html#cfn-redshift-redshiftidcapplication-lakeformationscopeunion-lakeformationquery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LakeFormationQuery
            /// </summary>
            public Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.LakeFormationQuery, BaseFunction>? LakeFormationQuery { get; set; }
        }

        public class ReadWriteAccess : Humidifier.Base.BaseSubResource, IHaveAuthorization
        {
            /// <summary>
            /// Authorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-readwriteaccess.html#cfn-redshift-redshiftidcapplication-readwriteaccess-authorization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Authorization { get; set; }
        }

        public class RedshiftScopeUnion : Humidifier.Base.BaseSubResource, IHaveRedshiftRedshiftIdcApplicationTypesConnectConnect
        {
            /// <summary>
            /// Connect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-redshiftscopeunion.html#cfn-redshift-redshiftidcapplication-redshiftscopeunion-connect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Connect
            /// </summary>
            public Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.Connect, BaseFunction>? Connect { get; set; }
        }

        public class S3AccessGrantsScopeUnion : Humidifier.Base.BaseSubResource, IHaveRedshiftRedshiftIdcApplicationTypesReadWriteAccessReadWriteAccess
        {
            /// <summary>
            /// ReadWriteAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-s3accessgrantsscopeunion.html#cfn-redshift-redshiftidcapplication-s3accessgrantsscopeunion-readwriteaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadWriteAccess
            /// </summary>
            public Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.ReadWriteAccess, BaseFunction>? ReadWriteAccess { get; set; }
        }

        public class ServiceIntegrationsUnion : Humidifier.Base.BaseSubResource, IHaveListOfRedshiftRedshiftIdcApplicationTypesLakeFormationScopeUnionLakeFormation, IHaveListOfRedshiftRedshiftIdcApplicationTypesS3AccessGrantsScopeUnionS3AccessGrants, IHaveListOfRedshiftRedshiftIdcApplicationTypesRedshiftScopeUnionRedshift
        {
            /// <summary>
            /// LakeFormation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-serviceintegrationsunion.html#cfn-redshift-redshiftidcapplication-serviceintegrationsunion-lakeformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LakeFormationScopeUnion
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Redshift.RedshiftIdcApplicationTypes.LakeFormationScopeUnion>, IReadOnlyList<Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.LakeFormationScopeUnion, BaseFunction>>, BaseFunction>? LakeFormation { get; set; }
            /// <summary>
            /// S3AccessGrants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-serviceintegrationsunion.html#cfn-redshift-redshiftidcapplication-serviceintegrationsunion-s3accessgrants
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: S3AccessGrantsScopeUnion
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Redshift.RedshiftIdcApplicationTypes.S3AccessGrantsScopeUnion>, IReadOnlyList<Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.S3AccessGrantsScopeUnion, BaseFunction>>, BaseFunction>? S3AccessGrants { get; set; }
            /// <summary>
            /// Redshift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-serviceintegrationsunion.html#cfn-redshift-redshiftidcapplication-serviceintegrationsunion-redshift
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RedshiftScopeUnion
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Redshift.RedshiftIdcApplicationTypes.RedshiftScopeUnion>, IReadOnlyList<Union<Humidifier.Redshift.RedshiftIdcApplicationTypes.RedshiftScopeUnion, BaseFunction>>, BaseFunction>? Redshift { get; set; }
        }
    }
}