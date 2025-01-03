namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using CommandTypes;

    public class Command : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHaveDisplayName
    {
        public class Attributes
        {
            public static string CommandArn =  "CommandArn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.Command; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// LastUpdatedAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-lastupdatedat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LastUpdatedAt { get; set; }
        /// <summary>
        /// Deprecated
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-deprecated
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Deprecated { get; set; }
        /// <summary>
        /// CreatedAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-createdat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CreatedAt { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// Payload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-payload
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CommandPayload
        /// </summary>
        public Humidifier.IoT.CommandTypes.CommandPayload Payload { get; set; }

        /// <summary>
        /// CommandId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-commandid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CommandId { get; set; }
        /// <summary>
        /// PendingDeletion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-pendingdeletion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PendingDeletion { get; set; }
        /// <summary>
        /// MandatoryParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-mandatoryparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CommandParameter
        /// </summary>
        public List<Humidifier.IoT.CommandTypes.CommandParameter> MandatoryParameters { get; set; }
        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-namespace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Namespace_ { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-command.html#cfn-iot-command-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace CommandTypes
    {
        public class CommandParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommandParameterValue
            /// </summary>
            public Humidifier.IoT.CommandTypes.CommandParameterValue DefaultValue { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CommandParameterValue
            /// </summary>
            public Humidifier.IoT.CommandTypes.CommandParameterValue Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparameter.html#cfn-iot-command-commandparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CommandParameterValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// B
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-b
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic B { get; set; }
            /// <summary>
            /// S
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-s
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S { get; set; }
            /// <summary>
            /// D
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-d
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic D { get; set; }
            /// <summary>
            /// BIN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-bin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BIN { get; set; }
            /// <summary>
            /// UL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-ul
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UL { get; set; }
            /// <summary>
            /// I
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-i
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic I { get; set; }
            /// <summary>
            /// L
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandparametervalue.html#cfn-iot-command-commandparametervalue-l
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic L { get; set; }
        }

        public class CommandPayload : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContent
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandpayload.html#cfn-iot-command-commandpayload-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-command-commandpayload.html#cfn-iot-command-commandpayload-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
        }
    }
}