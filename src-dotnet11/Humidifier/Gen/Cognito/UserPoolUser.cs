namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolUserTypes;

    public class UserPoolUser : Humidifier.Base.BaseResource, IHaveListOfCognitoUserPoolUserTypesAttributeTypeValidationData, IHaveUserPoolId, IHaveUsername, IHaveMessageAction, IHaveStringDictionaryOfClientMetadata, IHaveStringListOfDesiredDeliveryMediums, IHaveForceAliasCreation_Boolean, IHaveListOfCognitoUserPoolUserTypesAttributeTypeUserAttributes
    {
        public override string AWSTypeName { get => AWS.Cognito.UserPoolUser; }
        /// <summary>
        /// ValidationData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-validationdata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AttributeType
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.UserPoolUserTypes.AttributeType>, IReadOnlyList<Union<Humidifier.Cognito.UserPoolUserTypes.AttributeType, BaseFunction>>, BaseFunction>? ValidationData { get; set; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }
        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-username
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Username { get; set; }
        /// <summary>
        /// MessageAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-messageaction
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MessageAction { get; set; }
        /// <summary>
        /// ClientMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-clientmetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ClientMetadata { get; set; }
        /// <summary>
        /// DesiredDeliveryMediums
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-desireddeliverymediums
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DesiredDeliveryMediums { get; set; }
        /// <summary>
        /// ForceAliasCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-forcealiascreation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ForceAliasCreation { get; set; }
        /// <summary>
        /// UserAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-userattributes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AttributeType
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.UserPoolUserTypes.AttributeType>, IReadOnlyList<Union<Humidifier.Cognito.UserPoolUserTypes.AttributeType, BaseFunction>>, BaseFunction>? UserAttributes { get; set; }
    }

    namespace UserPoolUserTypes
    {
        public class AttributeType : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooluser-attributetype.html#cfn-cognito-userpooluser-attributetype-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooluser-attributetype.html#cfn-cognito-userpooluser-attributetype-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}