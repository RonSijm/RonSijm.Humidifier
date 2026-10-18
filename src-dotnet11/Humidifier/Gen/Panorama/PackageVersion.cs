namespace Humidifier.Panorama
{
    using global::System.Collections.Generic;

    public class PackageVersion : Humidifier.Base.BaseResource, IHaveUpdatedLatestPatchVersion, IHavePatchVersion, IHaveMarkLatest_Boolean, IHavePackageId, IHaveOwnerAccount, IHavePackageVersion_
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PackageName =  "PackageName" ;
            public static string StatusDescription =  "StatusDescription" ;
            public static string PackageArn =  "PackageArn" ;
            public static string IsLatestPatch =  "IsLatestPatch" ;
            public static string RegisteredTime =  "RegisteredTime" ;
        }

        public override string AWSTypeName { get => AWS.Panorama.PackageVersion; }
        /// <summary>
        /// UpdatedLatestPatchVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-packageversion.html#cfn-panorama-packageversion-updatedlatestpatchversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UpdatedLatestPatchVersion { get; set; }

        /// <summary>
        /// PatchVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-packageversion.html#cfn-panorama-packageversion-patchversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PatchVersion { get; set; }
        /// <summary>
        /// MarkLatest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-packageversion.html#cfn-panorama-packageversion-marklatest
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? MarkLatest { get; set; }

        /// <summary>
        /// PackageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-packageversion.html#cfn-panorama-packageversion-packageid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PackageId { get; set; }
        /// <summary>
        /// OwnerAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-packageversion.html#cfn-panorama-packageversion-owneraccount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OwnerAccount { get; set; }

        /// <summary>
        /// PackageVersion_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-panorama-packageversion.html#cfn-panorama-packageversion-packageversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PackageVersion_ { get; set; }
    }
}