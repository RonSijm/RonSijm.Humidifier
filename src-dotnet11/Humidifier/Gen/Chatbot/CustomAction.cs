namespace Humidifier.Chatbot
{
    using global::System.Collections.Generic;
    using CustomActionTypes;

    public class CustomAction : Humidifier.Base.BaseResource, IHaveTags, IHaveActionName, IHaveAliasName, IHaveChatbotCustomActionTypesCustomActionDefinitionDefinition, IHaveListOfChatbotCustomActionTypesCustomActionAttachmentAttachments
    {
        public class Attributes
        {
            public static string CustomActionArn =  "CustomActionArn" ;
        }

        public override string AWSTypeName { get => AWS.Chatbot.CustomAction; }

        /// <summary>
        /// ActionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-actionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ActionName { get; set; }
        /// <summary>
        /// AliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-aliasname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AliasName { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CustomActionDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// Attachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-attachments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomActionAttachment
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment>, IReadOnlyList<Union<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment, BaseFunction>>, BaseFunction>? Attachments { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CustomActionTypes
    {
        public class CustomActionAttachment : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfVariables, IHaveNotificationType, IHaveListOfChatbotCustomActionTypesCustomActionAttachmentCriteriaCriteria, IHaveButtonText
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// NotificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-notificationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationType { get; set; }
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-criteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomActionAttachmentCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachmentCriteria>, IReadOnlyList<Union<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachmentCriteria, BaseFunction>>, BaseFunction>? Criteria { get; set; }
            /// <summary>
            /// ButtonText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-buttontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ButtonText { get; set; }
        }

        public class CustomActionAttachmentCriteria : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveVariableName, IHaveValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachmentcriteria.html#cfn-chatbot-customaction-customactionattachmentcriteria-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// VariableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachmentcriteria.html#cfn-chatbot-customaction-customactionattachmentcriteria-variablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariableName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachmentcriteria.html#cfn-chatbot-customaction-customactionattachmentcriteria-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class CustomActionDefinition : Humidifier.Base.BaseSubResource, IHaveCommandText
        {
            /// <summary>
            /// CommandText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactiondefinition.html#cfn-chatbot-customaction-customactiondefinition-commandtext
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommandText { get; set; }
        }
    }
}