namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using ManagedLoginBrandingTypes;

    public class ManagedLoginBranding : Humidifier.Base.BaseResource, IHaveUserPoolId, IHaveUseCognitoProvidedValues_Boolean, IHaveListOfCognitoManagedLoginBrandingTypesAssetTypeAssets, IHaveClientId, IHaveSettings_Json, IHaveReturnMergedResources_Boolean
    {
        public class Attributes
        {
            public static string ManagedLoginBrandingId =  "ManagedLoginBrandingId" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.ManagedLoginBranding; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-managedloginbranding.html#cfn-cognito-managedloginbranding-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }
        /// <summary>
        /// UseCognitoProvidedValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-managedloginbranding.html#cfn-cognito-managedloginbranding-usecognitoprovidedvalues
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseCognitoProvidedValues { get; set; }
        /// <summary>
        /// Assets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-managedloginbranding.html#cfn-cognito-managedloginbranding-assets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetType
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType>, IReadOnlyList<Union<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType, BaseFunction>>, BaseFunction>? Assets { get; set; }
        /// <summary>
        /// ClientId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-managedloginbranding.html#cfn-cognito-managedloginbranding-clientid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientId { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-managedloginbranding.html#cfn-cognito-managedloginbranding-settings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Settings { get; set; }
        /// <summary>
        /// ReturnMergedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-managedloginbranding.html#cfn-cognito-managedloginbranding-returnmergedresources
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReturnMergedResources { get; set; }
    }

    namespace ManagedLoginBrandingTypes
    {
        public class AssetType : Humidifier.Base.BaseSubResource, IHaveExtension, IHaveBytes, IHaveCategory, IHaveResourceId, IHaveColorMode
        {
            /// <summary>
            /// Extension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-managedloginbranding-assettype.html#cfn-cognito-managedloginbranding-assettype-extension
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Extension { get; set; }
            /// <summary>
            /// Bytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-managedloginbranding-assettype.html#cfn-cognito-managedloginbranding-assettype-bytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bytes { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-managedloginbranding-assettype.html#cfn-cognito-managedloginbranding-assettype-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-managedloginbranding-assettype.html#cfn-cognito-managedloginbranding-assettype-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// ColorMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-managedloginbranding-assettype.html#cfn-cognito-managedloginbranding-assettype-colormode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorMode { get; set; }
        }
    }
}