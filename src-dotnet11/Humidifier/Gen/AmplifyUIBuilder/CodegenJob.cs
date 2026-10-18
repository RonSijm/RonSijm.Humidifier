namespace Humidifier.AmplifyUIBuilder
{
    using global::System.Collections.Generic;
    using CodegenJobTypes;

    public class CodegenJob : Humidifier.Base.BaseResource, IHaveAppId, IHaveAmplifyUIBuilderCodegenJobTypesCodegenJobRenderConfigRenderConfig, IHaveEnvironmentName, IHaveAmplifyUIBuilderCodegenJobTypesCodegenFeatureFlagsFeatures, IHaveAutoGenerateForms_Boolean
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
        public Union<string, BaseFunction>? AppId { get; set; }

        /// <summary>
        /// RenderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-renderconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CodegenJobRenderConfig
        /// </summary>
        [Required]
        public Union<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig, BaseFunction>? RenderConfig { get; set; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-environmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentName { get; set; }
        /// <summary>
        /// Features
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-features
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CodegenFeatureFlags
        /// </summary>
        public Union<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags, BaseFunction>? Features { get; set; }
        /// <summary>
        /// AutoGenerateForms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-codegenjob.html#cfn-amplifyuibuilder-codegenjob-autogenerateforms
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoGenerateForms { get; set; }
    }

    namespace CodegenJobTypes
    {
        public class ApiConfiguration : Humidifier.Base.BaseSubResource, IHaveDataStoreConfig_Json, IHaveNoApiConfig_Json, IHaveAmplifyUIBuilderCodegenJobTypesGraphQLRenderConfigGraphQLConfig
        {
            /// <summary>
            /// DataStoreConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-apiconfiguration.html#cfn-amplifyuibuilder-codegenjob-apiconfiguration-datastoreconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? DataStoreConfig { get; set; }
            /// <summary>
            /// NoApiConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-apiconfiguration.html#cfn-amplifyuibuilder-codegenjob-apiconfiguration-noapiconfig
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? NoApiConfig { get; set; }
            /// <summary>
            /// GraphQLConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-apiconfiguration.html#cfn-amplifyuibuilder-codegenjob-apiconfiguration-graphqlconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GraphQLRenderConfig
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig, BaseFunction>? GraphQLConfig { get; set; }
        }

        public class CodegenFeatureFlags : Humidifier.Base.BaseSubResource, IHaveIsRelationshipSupported_Boolean, IHaveIsNonModelSupported_Boolean
        {
            /// <summary>
            /// IsRelationshipSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-codegenfeatureflags.html#cfn-amplifyuibuilder-codegenjob-codegenfeatureflags-isrelationshipsupported
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsRelationshipSupported { get; set; }
            /// <summary>
            /// IsNonModelSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-codegenfeatureflags.html#cfn-amplifyuibuilder-codegenjob-codegenfeatureflags-isnonmodelsupported
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsNonModelSupported { get; set; }
        }

        public class CodegenJobRenderConfig : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderCodegenJobTypesReactStartCodegenJobDataReact
        {
            /// <summary>
            /// React
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-codegenjobrenderconfig.html#cfn-amplifyuibuilder-codegenjob-codegenjobrenderconfig-react
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ReactStartCodegenJobData
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData, BaseFunction>? React { get; set; }
        }

        public class GraphQLRenderConfig : Humidifier.Base.BaseSubResource, IHaveMutationsFilePath, IHaveFragmentsFilePath, IHaveTypesFilePath, IHaveSubscriptionsFilePath, IHaveQueriesFilePath
        {
            /// <summary>
            /// MutationsFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-mutationsfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MutationsFilePath { get; set; }
            /// <summary>
            /// FragmentsFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-fragmentsfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FragmentsFilePath { get; set; }
            /// <summary>
            /// TypesFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-typesfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypesFilePath { get; set; }
            /// <summary>
            /// SubscriptionsFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-subscriptionsfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscriptionsFilePath { get; set; }
            /// <summary>
            /// QueriesFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-graphqlrenderconfig.html#cfn-amplifyuibuilder-codegenjob-graphqlrenderconfig-queriesfilepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueriesFilePath { get; set; }
        }

        public class ReactStartCodegenJobData : Humidifier.Base.BaseSubResource, IHaveScript, IHaveRenderTypeDeclarations_Boolean, IHaveTarget, IHaveModule, IHaveInlineSourceMap_Boolean, IHaveAmplifyUIBuilderCodegenJobTypesApiConfigurationApiConfiguration
        {
            /// <summary>
            /// Script
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-script
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Script { get; set; }
            /// <summary>
            /// RenderTypeDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-rendertypedeclarations
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RenderTypeDeclarations { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-target
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Module
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-module
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Module { get; set; }
            /// <summary>
            /// InlineSourceMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-inlinesourcemap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InlineSourceMap { get; set; }
            /// <summary>
            /// ApiConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-codegenjob-reactstartcodegenjobdata.html#cfn-amplifyuibuilder-codegenjob-reactstartcodegenjobdata-apiconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ApiConfiguration
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration, BaseFunction>? ApiConfiguration { get; set; }
        }
    }
}