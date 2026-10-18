namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;

    public class GraphQLSchema : Humidifier.Base.BaseResource, IHaveDefinition, IHaveDefinitionS3Location, IHaveApiId
    {
        public override string AWSTypeName { get => AWS.AppSync.GraphQLSchema; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html#cfn-appsync-graphqlschema-definition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// DefinitionS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html#cfn-appsync-graphqlschema-definitions3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefinitionS3Location { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html#cfn-appsync-graphqlschema-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
    }
}