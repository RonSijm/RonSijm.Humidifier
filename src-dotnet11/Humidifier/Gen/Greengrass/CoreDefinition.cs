namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using CoreDefinitionTypes;

    public class CoreDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassCoreDefinitionTypesCoreDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.CoreDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CoreDefinitionVersion
        /// </summary>
        public Union<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html#cfn-greengrass-coredefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CoreDefinitionTypes
    {
        public class Core : Humidifier.Base.BaseSubResource, IHaveSyncShadow_Boolean, IHaveThingArn, IHaveId, IHaveCertificateArn
        {
            /// <summary>
            /// SyncShadow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-core.html#cfn-greengrass-coredefinition-core-syncshadow
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SyncShadow { get; set; }
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-core.html#cfn-greengrass-coredefinition-core-thingarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-core.html#cfn-greengrass-coredefinition-core-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-core.html#cfn-greengrass-coredefinition-core-certificatearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class CoreDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassCoreDefinitionTypesCoreCores
        {
            /// <summary>
            /// Cores
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-coredefinitionversion.html#cfn-greengrass-coredefinition-coredefinitionversion-cores
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Core
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.CoreDefinitionTypes.Core>, IReadOnlyList<Union<Humidifier.Greengrass.CoreDefinitionTypes.Core, BaseFunction>>, BaseFunction>? Cores { get; set; }
        }
    }
}