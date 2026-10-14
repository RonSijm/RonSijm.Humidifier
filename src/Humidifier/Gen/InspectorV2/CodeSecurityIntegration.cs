namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using CodeSecurityIntegrationTypes;

    public class CodeSecurityIntegration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AuthorizationUrl =  "AuthorizationUrl" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string StatusReason =  "StatusReason" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.InspectorV2.CodeSecurityIntegration; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityintegration.html#cfn-inspectorv2-codesecurityintegration-type
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// CreateIntegrationDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityintegration.html#cfn-inspectorv2-codesecurityintegration-createintegrationdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CreateDetails
        /// </summary>
        public Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails CreateIntegrationDetails { get; set; }
        /// <summary>
        /// UpdateIntegrationDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityintegration.html#cfn-inspectorv2-codesecurityintegration-updateintegrationdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpdateDetails
        /// </summary>
        public Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateDetails UpdateIntegrationDetails { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityintegration.html#cfn-inspectorv2-codesecurityintegration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CodeSecurityIntegrationTypes
    {
        public class CreateDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// gitlabSelfManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-createdetails.html#cfn-inspectorv2-codesecurityintegration-createdetails-gitlabselfmanaged
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CreateGitLabSelfManagedIntegrationDetail
            /// </summary>
            public Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail gitlabSelfManaged { get; set; }
        }

        public class CreateGitLabSelfManagedIntegrationDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// accessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-creategitlabselfmanagedintegrationdetail.html#cfn-inspectorv2-codesecurityintegration-creategitlabselfmanagedintegrationdetail-accesstoken
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic accessToken { get; set; }
            /// <summary>
            /// instanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-creategitlabselfmanagedintegrationdetail.html#cfn-inspectorv2-codesecurityintegration-creategitlabselfmanagedintegrationdetail-instanceurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic instanceUrl { get; set; }
        }

        public class UpdateDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// gitlabSelfManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-updatedetails.html#cfn-inspectorv2-codesecurityintegration-updatedetails-gitlabselfmanaged
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpdateGitLabSelfManagedIntegrationDetail
            /// </summary>
            public Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitLabSelfManagedIntegrationDetail gitlabSelfManaged { get; set; }
            /// <summary>
            /// github
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-updatedetails.html#cfn-inspectorv2-codesecurityintegration-updatedetails-github
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpdateGitHubIntegrationDetail
            /// </summary>
            public Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitHubIntegrationDetail github { get; set; }
        }

        public class UpdateGitHubIntegrationDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-updategithubintegrationdetail.html#cfn-inspectorv2-codesecurityintegration-updategithubintegrationdetail-code
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic code { get; set; }
            /// <summary>
            /// installationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-updategithubintegrationdetail.html#cfn-inspectorv2-codesecurityintegration-updategithubintegrationdetail-installationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic installationId { get; set; }
        }

        public class UpdateGitLabSelfManagedIntegrationDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// authCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityintegration-updategitlabselfmanagedintegrationdetail.html#cfn-inspectorv2-codesecurityintegration-updategitlabselfmanagedintegrationdetail-authcode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic authCode { get; set; }
        }
    }
}