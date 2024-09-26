namespace Humidifier.Panorama
{
    using System.Collections.Generic;
    using PackageTypes;

    public class Package : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePackageName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string PackageId =  "PackageId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Panorama.Package; }
        public dynamic PackageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// StorageLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-package.html#cfn-panorama-package-storagelocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StorageLocation
        /// </summary>
        public Humidifier.Panorama.PackageTypes.StorageLocation StorageLocation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-package.html#cfn-panorama-package-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace PackageTypes
    {
        public class StorageLocation : Humidifier.Base.BaseSubResource, IHaveBucket
        {
            /// <summary>
            /// RepoPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-repoprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepoPrefixLocation { get; set; }
            /// <summary>
            /// GeneratedPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-generatedprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeneratedPrefixLocation { get; set; }
            /// <summary>
            /// BinaryPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-binaryprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BinaryPrefixLocation { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// ManifestPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-manifestprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestPrefixLocation { get; set; }
        }
    }
}