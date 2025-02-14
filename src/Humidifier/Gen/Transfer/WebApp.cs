namespace Humidifier.Transfer
{
    using System.Collections.Generic;
    using WebAppTypes;

    public class WebApp : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string WebAppId =  "WebAppId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.WebApp; }
        /// <summary>
        /// WebAppCustomization
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-webappcustomization
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebAppCustomization
        /// </summary>
        public Humidifier.Transfer.WebAppTypes.WebAppCustomization WebAppCustomization { get; set; }

        /// <summary>
        /// IdentityProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-identityproviderdetails
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdentityProviderDetails
        /// </summary>
        [Required]
        public Humidifier.Transfer.WebAppTypes.IdentityProviderDetails IdentityProviderDetails { get; set; }
        /// <summary>
        /// WebAppUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-webappunits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebAppUnits
        /// </summary>
        public Humidifier.Transfer.WebAppTypes.WebAppUnits WebAppUnits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// AccessEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-accessendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessEndpoint { get; set; }
    }

    namespace WebAppTypes
    {
        public class IdentityProviderDetails : Humidifier.Base.BaseSubResource, IHaveInstanceArn, IHaveRole, IHaveApplicationArn
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-identityproviderdetails.html#cfn-transfer-webapp-identityproviderdetails-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-identityproviderdetails.html#cfn-transfer-webapp-identityproviderdetails-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationArn { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-identityproviderdetails.html#cfn-transfer-webapp-identityproviderdetails-instancearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceArn { get; set; }
        }

        public class WebAppCustomization : Humidifier.Base.BaseSubResource, IHaveTitle
        {
            /// <summary>
            /// FaviconFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappcustomization.html#cfn-transfer-webapp-webappcustomization-faviconfile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FaviconFile { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappcustomization.html#cfn-transfer-webapp-webappcustomization-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// LogoFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappcustomization.html#cfn-transfer-webapp-webappcustomization-logofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogoFile { get; set; }
        }

        public class WebAppUnits : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Provisioned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappunits.html#cfn-transfer-webapp-webappunits-provisioned
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Provisioned { get; set; }
        }
    }
}