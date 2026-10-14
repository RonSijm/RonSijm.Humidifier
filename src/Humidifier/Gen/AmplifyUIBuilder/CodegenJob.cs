namespace Humidifier.AmplifyUIBuilder
{
    using global::System.Collections.Generic;
    using CodegenJobTypes;

    public class CodegenJob : Humidifier.Base.BaseResource, IHaveAppId, IHaveEnvironmentName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.AmplifyUIBuilder.CodegenJob; }
        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-appid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AppId { get; set; }

        /// <summary>
        /// RenderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-renderconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CodegenJobRenderConfig
        /// </summary>
        [Required]
        public Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig RenderConfig { get; set; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-environmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentName { get; set; }
        /// <summary>
        /// Features
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-features
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CodegenFeatureFlags
        /// </summary>
        public Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags Features { get; set; }
        /// <summary>
        /// AutoGenerateForms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-autogenerateforms
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoGenerateForms { get; set; }
    }

    namespace CodegenJobTypes
    {
        public class ApiConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataStoreConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-apiconfiguration.html#cfn-amplifyuibuilder-codegenjob-apiconfiguration-datastoreconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic DataStoreConfig { get; set; }
            /// <summary>
            /// NoApiConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-apiconfiguration.html#cfn-amplifyuibuilder-codegenjob-apiconfiguration-noapiconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic NoApiConfig { get; set; }
            /// <summary>
            /// GraphQLConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-apiconfiguration.html#cfn-amplifyuibuilder-codegenjob-apiconfiguration-graphqlconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GraphQLRenderConfig
            /// </summary>
            public Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig GraphQLConfig { get; set; }
        }

        public class CodegenFeatureFlags : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsRelationshipSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-codegenfeatureflags.html#cfn-amplifyuibuilder-codegenjob-codegenfeatureflags-isrelationshipsupported
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsRelationshipSupported { get; set; }
            /// <summary>
            /// IsNonModelSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-codegenfeatureflags.html#cfn-amplifyuibuilder-codegenjob-codegenfeatureflags-isnonmodelsupported
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsNonModelSupported { get; set; }
        }

        public class CodegenJobRenderConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// React
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-codegenjobrenderconfig.html#cfn-amplifyuibuilder-codegenjob-codegenjobrenderconfig-react
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ReactStartCodegenJobData
            /// </summary>
            public Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData React { get; set; }
        }

        public class GraphQLRenderConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MutationsFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-mutationsfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MutationsFilePath { get; set; }
            /// <summary>
            /// FragmentsFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-fragmentsfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FragmentsFilePath { get; set; }
            /// <summary>
            /// TypesFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-typesfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypesFilePath { get; set; }
            /// <summary>
            /// SubscriptionsFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-subscriptionsfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubscriptionsFilePath { get; set; }
            /// <summary>
            /// QueriesFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-queriesfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueriesFilePath { get; set; }
        }

        public class ReactStartCodegenJobData : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveScript
        {
            /// <summary>
            /// Script
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-script
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Script { get; set; }
            /// <summary>
            /// RenderTypeDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-rendertypedeclarations
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RenderTypeDeclarations { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-target
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Module
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-module
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Module { get; set; }
            /// <summary>
            /// InlineSourceMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-inlinesourcemap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic InlineSourceMap { get; set; }
            /// <summary>
            /// ApiConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-apiconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ApiConfiguration
            /// </summary>
            public Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration ApiConfiguration { get; set; }
        }
    }
}