namespace Humidifier.Panorama
{
    using global::System.Collections.Generic;
    using PackageTypes;

    public class Package : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePackageName, IHavePanoramaPackageTypesStorageLocationStorageLocation
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string PackageId =  "PackageId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Panorama.Package; }
        public Union<string, BaseFunction>? PackageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// StorageLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-package.html#cfn-panorama-package-storagelocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StorageLocation
        /// </summary>
        public Union<Humidifier.Panorama.PackageTypes.StorageLocation, BaseFunction>? StorageLocation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-package.html#cfn-panorama-package-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PackageTypes
    {
        public class StorageLocation : Humidifier.Base.BaseSubResource, IHaveRepoPrefixLocation, IHaveGeneratedPrefixLocation, IHaveBinaryPrefixLocation, IHaveBucket, IHaveManifestPrefixLocation
        {
            /// <summary>
            /// RepoPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-repoprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepoPrefixLocation { get; set; }
            /// <summary>
            /// GeneratedPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-generatedprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeneratedPrefixLocation { get; set; }
            /// <summary>
            /// BinaryPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-binaryprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BinaryPrefixLocation { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ManifestPrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-panorama-package-storagelocation.html#cfn-panorama-package-storagelocation-manifestprefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestPrefixLocation { get; set; }
        }
    }
}