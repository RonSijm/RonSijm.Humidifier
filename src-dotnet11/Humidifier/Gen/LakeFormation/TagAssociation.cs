namespace Humidifier.LakeFormation
{
    using global::System.Collections.Generic;
    using TagAssociationTypes;

    public class TagAssociation : Humidifier.Base.BaseResource, IHaveListOfLakeFormationTagAssociationTypesLFTagPairLFTags, IHaveLakeFormationTagAssociationTypesResourceResource
    {
        public class Attributes
        {
            public static string ResourceIdentifier =  "ResourceIdentifier" ;
            public static string TagsIdentifier =  "TagsIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.LakeFormation.TagAssociation; }

        /// <summary>
        /// LFTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-tagassociation.html#cfn-lakeformation-tagassociation-lftags
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LFTagPair
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair>, IReadOnlyList<Union<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair, BaseFunction>>, BaseFunction>? LFTags { get; set; }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-tagassociation.html#cfn-lakeformation-tagassociation-resource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Resource
        /// </summary>
        [Required]
        public Union<Humidifier.LakeFormation.TagAssociationTypes.Resource, BaseFunction>? Resource { get; set; }
    }

    namespace TagAssociationTypes
    {
        public class DatabaseResource : Humidifier.Base.BaseSubResource, IHaveCatalogId, IHaveName
        {
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-databaseresource.html#cfn-lakeformation-tagassociation-databaseresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-databaseresource.html#cfn-lakeformation-tagassociation-databaseresource-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LFTagPair : Humidifier.Base.BaseSubResource, IHaveTagKey, IHaveCatalogId, IHaveStringListOfTagValues
        {
            /// <summary>
            /// TagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-lftagpair.html#cfn-lakeformation-tagassociation-lftagpair-tagkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagKey { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-lftagpair.html#cfn-lakeformation-tagassociation-lftagpair-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// TagValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-lftagpair.html#cfn-lakeformation-tagassociation-lftagpair-tagvalues
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagValues { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource, IHaveLakeFormationTagAssociationTypesTableResourceTable, IHaveLakeFormationTagAssociationTypesTableWithColumnsResourceTableWithColumns, IHaveLakeFormationTagAssociationTypesDatabaseResourceDatabase
        {
            /// <summary>
            /// Table
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-resource.html#cfn-lakeformation-tagassociation-resource-table
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TableResource
            /// </summary>
            public Union<Humidifier.LakeFormation.TagAssociationTypes.TableResource, BaseFunction>? Table { get; set; }
            /// <summary>
            /// TableWithColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-resource.html#cfn-lakeformation-tagassociation-resource-tablewithcolumns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TableWithColumnsResource
            /// </summary>
            public Union<Humidifier.LakeFormation.TagAssociationTypes.TableWithColumnsResource, BaseFunction>? TableWithColumns { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-resource.html#cfn-lakeformation-tagassociation-resource-database
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DatabaseResource
            /// </summary>
            public Union<Humidifier.LakeFormation.TagAssociationTypes.DatabaseResource, BaseFunction>? Database { get; set; }
        }

        public class TableResource : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveCatalogId, IHaveName
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tableresource.html#cfn-lakeformation-tagassociation-tableresource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tableresource.html#cfn-lakeformation-tagassociation-tableresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tableresource.html#cfn-lakeformation-tagassociation-tableresource-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TableWithColumnsResource : Humidifier.Base.BaseSubResource, IHaveStringListOfColumnNames, IHaveDatabaseName, IHaveCatalogId, IHaveName
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tablewithcolumnsresource.html#cfn-lakeformation-tagassociation-tablewithcolumnsresource-columnnames
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tablewithcolumnsresource.html#cfn-lakeformation-tagassociation-tablewithcolumnsresource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tablewithcolumnsresource.html#cfn-lakeformation-tagassociation-tablewithcolumnsresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-tagassociation-tablewithcolumnsresource.html#cfn-lakeformation-tagassociation-tablewithcolumnsresource-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}