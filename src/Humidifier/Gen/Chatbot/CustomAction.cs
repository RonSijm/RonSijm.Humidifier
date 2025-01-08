namespace Humidifier.Chatbot
{
    using System.Collections.Generic;
    using CustomActionTypes;

    public class CustomAction : Humidifier.Base.BaseResource, IHaveTags, IHaveActionName, IHaveAliasName
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
        public dynamic ActionName { get; set; }
        /// <summary>
        /// AliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-aliasname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AliasName { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CustomActionDefinition
        /// </summary>
        [Required]
        public Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition Definition { get; set; }
        /// <summary>
        /// Attachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-attachments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomActionAttachment
        /// </summary>
        public List<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> Attachments { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-customaction.html#cfn-chatbot-customaction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace CustomActionTypes
    {
        public class CustomActionAttachment : Humidifier.Base.BaseSubResource, IHaveNotificationType
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Variables { get; set; }
            /// <summary>
            /// NotificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-notificationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationType { get; set; }
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-criteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomActionAttachmentCriteria
            /// </summary>
            public List<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachmentCriteria> Criteria { get; set; }
            /// <summary>
            /// ButtonText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachment.html#cfn-chatbot-customaction-customactionattachment-buttontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ButtonText { get; set; }
        }

        public class CustomActionAttachmentCriteria : Humidifier.Base.BaseSubResource, IHaveValue, IHaveOperator, IHaveVariableName
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachmentcriteria.html#cfn-chatbot-customaction-customactionattachmentcriteria-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// VariableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachmentcriteria.html#cfn-chatbot-customaction-customactionattachmentcriteria-variablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariableName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactionattachmentcriteria.html#cfn-chatbot-customaction-customactionattachmentcriteria-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class CustomActionDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CommandText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chatbot-customaction-customactiondefinition.html#cfn-chatbot-customaction-customactiondefinition-commandtext
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommandText { get; set; }
        }
    }
}