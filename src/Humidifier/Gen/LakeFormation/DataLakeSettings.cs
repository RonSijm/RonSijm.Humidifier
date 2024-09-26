namespace Humidifier.LakeFormation
{
    using System.Collections.Generic;
    using DataLakeSettingsTypes;

    public class DataLakeSettings : Humidifier.Base.BaseResource, IHaveParameters
    {
        public override string AWSTypeName { get => AWS.LakeFormation.DataLakeSettings; }
        /// <summary>
        /// AllowExternalDataFiltering
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-allowexternaldatafiltering
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AllowExternalDataFiltering { get; set; }
        /// <summary>
        /// ExternalDataFilteringAllowList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-externaldatafilteringallowlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExternalDataFilteringAllowList
        /// </summary>
        public Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList ExternalDataFilteringAllowList { get; set; }
        /// <summary>
        /// CreateTableDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-createtabledefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CreateTableDefaultPermissions
        /// </summary>
        public Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions CreateTableDefaultPermissions { get; set; }
        /// <summary>
        /// MutationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-mutationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MutationType { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Parameters { get; set; }
        /// <summary>
        /// AllowFullTableExternalDataAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-allowfulltableexternaldataaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AllowFullTableExternalDataAccess { get; set; }
        /// <summary>
        /// Admins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-admins
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Admins
        /// </summary>
        public Humidifier.LakeFormation.DataLakeSettingsTypes.Admins Admins { get; set; }
        /// <summary>
        /// CreateDatabaseDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-createdatabasedefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CreateDatabaseDefaultPermissions
        /// </summary>
        public Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions CreateDatabaseDefaultPermissions { get; set; }
        /// <summary>
        /// AuthorizedSessionTagValueList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-authorizedsessiontagvaluelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AuthorizedSessionTagValueList { get; set; }
        /// <summary>
        /// TrustedResourceOwners
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-trustedresourceowners
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TrustedResourceOwners { get; set; }
    }

    namespace DataLakeSettingsTypes
    {
        public class Admins : Humidifier.Base.BaseSubResource
        {
        }

        public class CreateDatabaseDefaultPermissions : Humidifier.Base.BaseSubResource
        {
        }

        public class CreateTableDefaultPermissions : Humidifier.Base.BaseSubResource
        {
        }

        public class DataLakePrincipal : Humidifier.Base.BaseSubResource, IHaveDataLakePrincipalIdentifier
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-datalakeprincipal.html#cfn-lakeformation-datalakesettings-datalakeprincipal-datalakeprincipalidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataLakePrincipalIdentifier { get; set; }
        }

        public class ExternalDataFilteringAllowList : Humidifier.Base.BaseSubResource
        {
        }

        public class PrincipalPermissions : Humidifier.Base.BaseSubResource, IHavePermissions
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-principalpermissions.html#cfn-lakeformation-datalakesettings-principalpermissions-permissions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Permissions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-principalpermissions.html#cfn-lakeformation-datalakesettings-principalpermissions-principal
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataLakePrincipal
            /// </summary>
            public Humidifier.LakeFormation.DataLakeSettingsTypes.DataLakePrincipal Principal { get; set; }
        }
    }
}