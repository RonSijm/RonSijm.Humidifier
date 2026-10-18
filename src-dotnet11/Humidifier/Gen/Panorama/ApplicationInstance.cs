namespace Humidifier.Panorama
{
    using global::System.Collections.Generic;
    using ApplicationInstanceTypes;

    public class ApplicationInstance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDefaultRuntimeContextDevice, IHaveDescription, IHaveApplicationInstanceIdToReplace, IHavePanoramaApplicationInstanceTypesManifestOverridesPayloadManifestOverridesPayload, IHaveRuntimeRoleArn, IHavePanoramaApplicationInstanceTypesManifestPayloadManifestPayload, IHaveName
    {
        public class Attributes
        {
            public static string DefaultRuntimeContextDeviceName =  "DefaultRuntimeContextDeviceName" ;
            public static string Status =  "Status" ;
            public static string ApplicationInstanceId =  "ApplicationInstanceId" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string StatusDescription =  "StatusDescription" ;
            public static string HealthStatus =  "HealthStatus" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Panorama.ApplicationInstance; }

        /// <summary>
        /// DefaultRuntimeContextDevice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-defaultruntimecontextdevice
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DefaultRuntimeContextDevice { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ApplicationInstanceIdToReplace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-applicationinstanceidtoreplace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationInstanceIdToReplace { get; set; }
        /// <summary>
        /// ManifestOverridesPayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-manifestoverridespayload
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ManifestOverridesPayload
        /// </summary>
        public Union<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload, BaseFunction>? ManifestOverridesPayload { get; set; }
        /// <summary>
        /// RuntimeRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-runtimerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RuntimeRoleArn { get; set; }

        /// <summary>
        /// ManifestPayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-manifestpayload
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ManifestPayload
        /// </summary>
        [Required]
        public Union<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload, BaseFunction>? ManifestPayload { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApplicationInstanceTypes
    {
        public class ManifestOverridesPayload : Humidifier.Base.BaseSubResource, IHavePayloadData
        {
            /// <summary>
            /// PayloadData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-applicationinstance-manifestoverridespayload.html#cfn-panorama-applicationinstance-manifestoverridespayload-payloaddata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadData { get; set; }
        }

        public class ManifestPayload : Humidifier.Base.BaseSubResource, IHavePayloadData
        {
            /// <summary>
            /// PayloadData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-applicationinstance-manifestpayload.html#cfn-panorama-applicationinstance-manifestpayload-payloaddata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadData { get; set; }
        }
    }
}