namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;

    public class Terms : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEnforcement, IHaveUserPoolId, IHaveClientId, IHaveTermsName, IHaveStringDictionaryOfLinks, IHaveTermsSource
    {
        public class Attributes
        {
            public static string TermsId =  "TermsId" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.Terms; }

        /// <summary>
        /// Enforcement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-terms.html#cfn-cognito-terms-enforcement
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Enforcement { get; set; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-terms.html#cfn-cognito-terms-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }
        /// <summary>
        /// ClientId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-terms.html#cfn-cognito-terms-clientid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientId { get; set; }
        public Union<string, BaseFunction>? TermsName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Links
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-terms.html#cfn-cognito-terms-links
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Links { get; set; }

        /// <summary>
        /// TermsSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-terms.html#cfn-cognito-terms-termssource
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TermsSource { get; set; }
    }
}