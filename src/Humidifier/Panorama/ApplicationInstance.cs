namespace Humidifier.Panorama
{
    using System.Collections.Generic;
    using ApplicationInstanceTypes;

    public class ApplicationInstance : Humidifier.Resource, IHaveTags, IHaveDescription
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

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Panorama::ApplicationInstance";
            }
        }

        /// <summary>
        /// DefaultRuntimeContextDevice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-defaultruntimecontextdevice
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultRuntimeContextDevice { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ApplicationInstanceIdToReplace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-applicationinstanceidtoreplace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationInstanceIdToReplace { get; set; }
        /// <summary>
        /// ManifestOverridesPayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-manifestoverridespayload
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ManifestOverridesPayload
        /// </summary>
        public ManifestOverridesPayload ManifestOverridesPayload { get; set; }
        /// <summary>
        /// RuntimeRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-runtimerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RuntimeRoleArn { get; set; }
        /// <summary>
        /// ManifestPayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-manifestpayload
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ManifestPayload
        /// </summary>
        public ManifestPayload ManifestPayload { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-applicationinstance.html#cfn-panorama-applicationinstance-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ApplicationInstanceTypes
    {
        public class ManifestOverridesPayload
        {
            /// <summary>
            /// PayloadData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-applicationinstance-manifestoverridespayload.html#cfn-panorama-applicationinstance-manifestoverridespayload-payloaddata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadData { get; set; }
        }

        public class ManifestPayload
        {
            /// <summary>
            /// PayloadData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-applicationinstance-manifestpayload.html#cfn-panorama-applicationinstance-manifestpayload-payloaddata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadData { get; set; }
        }
    }
}