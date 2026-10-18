namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;

    public class ApiKey : Humidifier.Base.BaseResource, IHaveDescription, IHaveExpires_Double, IHaveApiId
    {
        public class Attributes
        {
            public static string ApiKey =  "ApiKey" ;
            public static string ApiKeyId =  "ApiKeyId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.ApiKey; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Expires
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-expires
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? Expires { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
    }
}