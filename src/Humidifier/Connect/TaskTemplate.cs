namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using TaskTemplateTypes;

    public class TaskTemplate : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Connect::TaskTemplate";
            }
        }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Constraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-constraints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Constraints
        /// </summary>
        public Constraints Constraints { get; set; }
        /// <summary>
        /// Defaults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-defaults
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DefaultFieldValue
        /// </summary>
        public List<DefaultFieldValue> Defaults { get; set; }
        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-fields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Field
        /// </summary>
        public List<Field> Fields { get; set; }
        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// ContactFlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-contactflowarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ContactFlowArn { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-clienttoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace TaskTemplateTypes
    {
        public class Constraints
        {
            /// <summary>
            /// ReadOnlyFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-constraints.html#cfn-connect-tasktemplate-constraints-readonlyfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReadOnlyFieldInfo
            /// </summary>
            public List<ReadOnlyFieldInfo> ReadOnlyFields { get; set; }
            /// <summary>
            /// InvisibleFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-constraints.html#cfn-connect-tasktemplate-constraints-invisiblefields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InvisibleFieldInfo
            /// </summary>
            public List<InvisibleFieldInfo> InvisibleFields { get; set; }
            /// <summary>
            /// RequiredFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-constraints.html#cfn-connect-tasktemplate-constraints-requiredfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RequiredFieldInfo
            /// </summary>
            public List<RequiredFieldInfo> RequiredFields { get; set; }
        }

        public class DefaultFieldValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-defaultfieldvalue.html#cfn-connect-tasktemplate-defaultfieldvalue-defaultvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-defaultfieldvalue.html#cfn-connect-tasktemplate-defaultfieldvalue-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier Id { get; set; }
        }

        public class Field
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier Id { get; set; }
            /// <summary>
            /// SingleSelectOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-singleselectoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SingleSelectOptions { get; set; }
        }

        public class FieldIdentifier
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-fieldidentifier.html#cfn-connect-tasktemplate-fieldidentifier-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class InvisibleFieldInfo
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-invisiblefieldinfo.html#cfn-connect-tasktemplate-invisiblefieldinfo-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier Id { get; set; }
        }

        public class ReadOnlyFieldInfo
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-readonlyfieldinfo.html#cfn-connect-tasktemplate-readonlyfieldinfo-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier Id { get; set; }
        }

        public class RequiredFieldInfo
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-requiredfieldinfo.html#cfn-connect-tasktemplate-requiredfieldinfo-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier Id { get; set; }
        }
    }
}