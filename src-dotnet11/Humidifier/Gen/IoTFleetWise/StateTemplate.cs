namespace Humidifier.IoTFleetWise
{
    using global::System.Collections.Generic;

    public class StateTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfStateTemplateProperties, IHaveDescription, IHaveStringListOfDataExtraDimensions, IHaveSignalCatalogArn, IHaveStringListOfMetadataExtraDimensions, IHaveName
    {
        public class Attributes
        {
            public static string LastModificationTime =  "LastModificationTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTFleetWise.StateTemplate; }

        /// <summary>
        /// StateTemplateProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-statetemplate.html#cfn-iotfleetwise-statetemplate-statetemplateproperties
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StateTemplateProperties { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-statetemplate.html#cfn-iotfleetwise-statetemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DataExtraDimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-statetemplate.html#cfn-iotfleetwise-statetemplate-dataextradimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DataExtraDimensions { get; set; }

        /// <summary>
        /// SignalCatalogArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-statetemplate.html#cfn-iotfleetwise-statetemplate-signalcatalogarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SignalCatalogArn { get; set; }
        /// <summary>
        /// MetadataExtraDimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-statetemplate.html#cfn-iotfleetwise-statetemplate-metadataextradimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetadataExtraDimensions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-statetemplate.html#cfn-iotfleetwise-statetemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}