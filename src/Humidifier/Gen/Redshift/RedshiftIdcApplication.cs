namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;
    using RedshiftIdcApplicationTypes;

    public class RedshiftIdcApplication : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIamRoleArn
    {
        public class Attributes
        {
            public static string IdcOnboardStatus =  "IdcOnboardStatus" ;
            public static string IdcManagedApplicationArn =  "IdcManagedApplicationArn" ;
            public static string RedshiftIdcApplicationArn =  "RedshiftIdcApplicationArn" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.RedshiftIdcApplication; }
        public dynamic RedshiftIdcApplicationName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// IdcDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-idcdisplayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IdcDisplayName { get; set; }
        /// <summary>
        /// ApplicationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-applicationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationType { get; set; }
        /// <summary>
        /// AuthorizedTokenIssuerList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-authorizedtokenissuerlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AuthorizedTokenIssuer
        /// </summary>
        public List<Humidifier.Redshift.RedshiftIdcApplicationTypes.AuthorizedTokenIssuer> AuthorizedTokenIssuerList { get; set; }

        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-iamrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IamRoleArn { get; set; }
        /// <summary>
        /// ServiceIntegrations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-serviceintegrations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ServiceIntegrationsUnion
        /// </summary>
        public List<Humidifier.Redshift.RedshiftIdcApplicationTypes.ServiceIntegrationsUnion> ServiceIntegrations { get; set; }
        /// <summary>
        /// IdentityNamespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-identitynamespace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityNamespace { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// SsoTagKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-ssotagkeys
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SsoTagKeys { get; set; }

        /// <summary>
        /// IdcInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-redshiftidcapplication.html#cfn-redshift-redshiftidcapplication-idcinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IdcInstanceArn { get; set; }
    }

    namespace RedshiftIdcApplicationTypes
    {
        public class AuthorizedTokenIssuer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrustedTokenIssuerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-authorizedtokenissuer.html#cfn-redshift-redshiftidcapplication-authorizedtokenissuer-trustedtokenissuerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrustedTokenIssuerArn { get; set; }
            /// <summary>
            /// AuthorizedAudiencesList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-authorizedtokenissuer.html#cfn-redshift-redshiftidcapplication-authorizedtokenissuer-authorizedaudienceslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AuthorizedAudiencesList { get; set; }
        }

        public class Connect : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Authorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-connect.html#cfn-redshift-redshiftidcapplication-connect-authorization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Authorization { get; set; }
        }

        public class LakeFormationQuery : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Authorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-lakeformationquery.html#cfn-redshift-redshiftidcapplication-lakeformationquery-authorization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Authorization { get; set; }
        }

        public class LakeFormationScopeUnion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LakeFormationQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-lakeformationscopeunion.html#cfn-redshift-redshiftidcapplication-lakeformationscopeunion-lakeformationquery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LakeFormationQuery
            /// </summary>
            public Humidifier.Redshift.RedshiftIdcApplicationTypes.LakeFormationQuery LakeFormationQuery { get; set; }
        }

        public class ReadWriteAccess : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Authorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-readwriteaccess.html#cfn-redshift-redshiftidcapplication-readwriteaccess-authorization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Authorization { get; set; }
        }

        public class RedshiftScopeUnion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Connect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-redshiftscopeunion.html#cfn-redshift-redshiftidcapplication-redshiftscopeunion-connect
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Connect
            /// </summary>
            public Humidifier.Redshift.RedshiftIdcApplicationTypes.Connect Connect { get; set; }
        }

        public class S3AccessGrantsScopeUnion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReadWriteAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-s3accessgrantsscopeunion.html#cfn-redshift-redshiftidcapplication-s3accessgrantsscopeunion-readwriteaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadWriteAccess
            /// </summary>
            public Humidifier.Redshift.RedshiftIdcApplicationTypes.ReadWriteAccess ReadWriteAccess { get; set; }
        }

        public class ServiceIntegrationsUnion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LakeFormation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-serviceintegrationsunion.html#cfn-redshift-redshiftidcapplication-serviceintegrationsunion-lakeformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LakeFormationScopeUnion
            /// </summary>
            public List<Humidifier.Redshift.RedshiftIdcApplicationTypes.LakeFormationScopeUnion> LakeFormation { get; set; }
            /// <summary>
            /// S3AccessGrants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-serviceintegrationsunion.html#cfn-redshift-redshiftidcapplication-serviceintegrationsunion-s3accessgrants
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: S3AccessGrantsScopeUnion
            /// </summary>
            public List<Humidifier.Redshift.RedshiftIdcApplicationTypes.S3AccessGrantsScopeUnion> S3AccessGrants { get; set; }
            /// <summary>
            /// Redshift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-redshiftidcapplication-serviceintegrationsunion.html#cfn-redshift-redshiftidcapplication-serviceintegrationsunion-redshift
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RedshiftScopeUnion
            /// </summary>
            public List<Humidifier.Redshift.RedshiftIdcApplicationTypes.RedshiftScopeUnion> Redshift { get; set; }
        }
    }
}