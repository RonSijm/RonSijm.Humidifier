namespace Humidifier.LakeFormation
{
    using global::System.Collections.Generic;
    using DataLakeSettingsTypes;

    public class DataLakeSettings : Humidifier.Base.BaseResource, IHaveAllowExternalDataFiltering_Boolean, IHaveLakeFormationDataLakeSettingsTypesExternalDataFilteringAllowListExternalDataFilteringAllowList, IHaveLakeFormationDataLakeSettingsTypesCreateTableDefaultPermissionsCreateTableDefaultPermissions, IHaveMutationType, IHaveParameters_Json, IHaveLakeFormationDataLakeSettingsTypesReadOnlyAdminsReadOnlyAdmins, IHaveAllowFullTableExternalDataAccess_Boolean, IHaveLakeFormationDataLakeSettingsTypesAdminsAdmins, IHaveLakeFormationDataLakeSettingsTypesCreateDatabaseDefaultPermissionsCreateDatabaseDefaultPermissions, IHaveStringListOfAuthorizedSessionTagValueList, IHaveStringListOfTrustedResourceOwners
    {
        public override string AWSTypeName { get => AWS.LakeFormation.DataLakeSettings; }
        /// <summary>
        /// AllowExternalDataFiltering
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-allowexternaldatafiltering
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowExternalDataFiltering { get; set; }
        /// <summary>
        /// ExternalDataFilteringAllowList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-externaldatafilteringallowlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExternalDataFilteringAllowList
        /// </summary>
        public Union<Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList, BaseFunction>? ExternalDataFilteringAllowList { get; set; }
        /// <summary>
        /// CreateTableDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-createtabledefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CreateTableDefaultPermissions
        /// </summary>
        public Union<Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions, BaseFunction>? CreateTableDefaultPermissions { get; set; }
        /// <summary>
        /// MutationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-mutationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MutationType { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// ReadOnlyAdmins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-readonlyadmins
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReadOnlyAdmins
        /// </summary>
        public Union<Humidifier.LakeFormation.DataLakeSettingsTypes.ReadOnlyAdmins, BaseFunction>? ReadOnlyAdmins { get; set; }
        /// <summary>
        /// AllowFullTableExternalDataAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-allowfulltableexternaldataaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowFullTableExternalDataAccess { get; set; }
        /// <summary>
        /// Admins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-admins
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Admins
        /// </summary>
        public Union<Humidifier.LakeFormation.DataLakeSettingsTypes.Admins, BaseFunction>? Admins { get; set; }
        /// <summary>
        /// CreateDatabaseDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-createdatabasedefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CreateDatabaseDefaultPermissions
        /// </summary>
        public Union<Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions, BaseFunction>? CreateDatabaseDefaultPermissions { get; set; }
        /// <summary>
        /// AuthorizedSessionTagValueList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-authorizedsessiontagvaluelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthorizedSessionTagValueList { get; set; }
        /// <summary>
        /// TrustedResourceOwners
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-trustedresourceowners
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TrustedResourceOwners { get; set; }
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
            public Union<string, BaseFunction>? DataLakePrincipalIdentifier { get; set; }
        }

        public class ExternalDataFilteringAllowList : Humidifier.Base.BaseSubResource
        {
        }

        public class PrincipalPermissions : Humidifier.Base.BaseSubResource, IHaveStringListOfPermissions, IHaveLakeFormationDataLakeSettingsTypesDataLakePrincipalPrincipal
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-principalpermissions.html#cfn-lakeformation-datalakesettings-principalpermissions-permissions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-principalpermissions.html#cfn-lakeformation-datalakesettings-principalpermissions-principal
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataLakePrincipal
            /// </summary>
            public Union<Humidifier.LakeFormation.DataLakeSettingsTypes.DataLakePrincipal, BaseFunction>? Principal { get; set; }
        }

        public class ReadOnlyAdmins : Humidifier.Base.BaseSubResource
        {
        }
    }
}