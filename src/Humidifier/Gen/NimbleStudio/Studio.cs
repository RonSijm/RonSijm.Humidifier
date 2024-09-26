namespace Humidifier.NimbleStudio
{
    using System.Collections.Generic;
    using StudioTypes;

    public class Studio : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDisplayName
    {
        public class Attributes
        {
            public static string HomeRegion =  "HomeRegion" ;
            public static string StudioUrl =  "StudioUrl" ;
            public static string SsoClientId =  "SsoClientId" ;
            public static string StudioId =  "StudioId" ;
        }

        public override string AWSTypeName { get => AWS.NimbleStudio.Studio; }

        /// <summary>
        /// UserRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-userrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UserRoleArn { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        public dynamic StudioName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// AdminRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-adminrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AdminRoleArn { get; set; }
        /// <summary>
        /// StudioEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioencryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StudioEncryptionConfiguration
        /// </summary>
        public Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration StudioEncryptionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace StudioTypes
    {
        public class StudioEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveKeyArn
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studio-studioencryptionconfiguration.html#cfn-nimblestudio-studio-studioencryptionconfiguration-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// KeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studio-studioencryptionconfiguration.html#cfn-nimblestudio-studio-studioencryptionconfiguration-keyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyArn { get; set; }
        }
    }
}