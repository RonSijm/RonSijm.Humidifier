namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using UrlTypes;

    public class Url : Humidifier.Base.BaseResource, IHaveQualifier, IHaveInvokeMode, IHaveAuthType, IHaveTargetFunctionArn, IHaveLambdaUrlTypesCorsCors
    {
        public class Attributes
        {
            public static string FunctionArn =  "FunctionArn" ;
            public static string FunctionUrl =  "FunctionUrl" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.Url; }
        /// <summary>
        /// Qualifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-url.html#cfn-lambda-url-qualifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Qualifier { get; set; }
        /// <summary>
        /// InvokeMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-url.html#cfn-lambda-url-invokemode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InvokeMode { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-url.html#cfn-lambda-url-authtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthType { get; set; }

        /// <summary>
        /// TargetFunctionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-url.html#cfn-lambda-url-targetfunctionarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetFunctionArn { get; set; }
        /// <summary>
        /// Cors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-url.html#cfn-lambda-url-cors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Cors
        /// </summary>
        public Union<Humidifier.Lambda.UrlTypes.Cors, BaseFunction>? Cors { get; set; }
    }

    namespace UrlTypes
    {
        public class Cors : Humidifier.Base.BaseSubResource, IHaveAllowCredentials_Boolean, IHaveStringListOfAllowOrigins, IHaveStringListOfExposeHeaders, IHaveStringListOfAllowHeaders, IHaveMaxAge_Integer, IHaveStringListOfAllowMethods
        {
            /// <summary>
            /// AllowCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-url-cors.html#cfn-lambda-url-cors-allowcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowCredentials { get; set; }
            /// <summary>
            /// AllowOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-url-cors.html#cfn-lambda-url-cors-alloworigins
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowOrigins { get; set; }
            /// <summary>
            /// ExposeHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-url-cors.html#cfn-lambda-url-cors-exposeheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExposeHeaders { get; set; }
            /// <summary>
            /// AllowHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-url-cors.html#cfn-lambda-url-cors-allowheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowHeaders { get; set; }
            /// <summary>
            /// MaxAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-url-cors.html#cfn-lambda-url-cors-maxage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAge { get; set; }
            /// <summary>
            /// AllowMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-url-cors.html#cfn-lambda-url-cors-allowmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowMethods { get; set; }
        }
    }
}