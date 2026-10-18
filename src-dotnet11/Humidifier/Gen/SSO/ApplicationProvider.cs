namespace Humidifier.SSO
{
    using global::System.Collections.Generic;
    using ApplicationProviderTypes;

    public class ApplicationProvider : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ApplicationProviderArn =  "ApplicationProviderArn" ;
            public static string FederationProtocol =  "FederationProtocol" ;
            public static string ResourceServerConfig =  "ResourceServerConfig" ;
            public static string DisplayData =  "DisplayData" ;
        }

        public override string AWSTypeName { get => AWS.SSO.ApplicationProvider; }
    }

    namespace ApplicationProviderTypes
    {
        public class DisplayData : Humidifier.Base.BaseSubResource, IHaveIconUrl, IHaveDescription, IHaveDisplayName
        {
            /// <summary>
            /// IconUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-applicationprovider-displaydata.html#cfn-sso-applicationprovider-displaydata-iconurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IconUrl { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-applicationprovider-displaydata.html#cfn-sso-applicationprovider-displaydata-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-applicationprovider-displaydata.html#cfn-sso-applicationprovider-displaydata-displayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayName { get; set; }
        }

        public class ResourceServerConfig : Humidifier.Base.BaseSubResource, IHaveMapOfSSOApplicationProviderTypesResourceServerScopeDetailsScopes
        {
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-applicationprovider-resourceserverconfig.html#cfn-sso-applicationprovider-resourceserverconfig-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ResourceServerScopeDetails
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.SSO.ApplicationProviderTypes.ResourceServerScopeDetails>, IReadOnlyDictionary<string, Union<Humidifier.SSO.ApplicationProviderTypes.ResourceServerScopeDetails, BaseFunction>>, BaseFunction>? Scopes { get; set; }
        }

        public class ResourceServerScopeDetails : Humidifier.Base.BaseSubResource, IHaveLongDescription, IHaveDetailedTitle
        {
            /// <summary>
            /// LongDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-applicationprovider-resourceserverscopedetails.html#cfn-sso-applicationprovider-resourceserverscopedetails-longdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LongDescription { get; set; }
            /// <summary>
            /// DetailedTitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-applicationprovider-resourceserverscopedetails.html#cfn-sso-applicationprovider-resourceserverscopedetails-detailedtitle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DetailedTitle { get; set; }
        }
    }
}