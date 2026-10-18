namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using TaskTemplateTypes;

    public class TaskTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveDescription, IHaveConnectTaskTemplateTypesConstraintsConstraints, IHaveListOfConnectTaskTemplateTypesDefaultFieldValueDefaults, IHaveListOfConnectTaskTemplateTypesFieldFields, IHaveInstanceArn, IHaveContactFlowArn, IHaveClientToken, IHaveSelfAssignContactFlowArn, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.TaskTemplate; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Constraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-constraints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Constraints
        /// </summary>
        public Union<Humidifier.Connect.TaskTemplateTypes.Constraints, BaseFunction>? Constraints { get; set; }
        /// <summary>
        /// Defaults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-defaults
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DefaultFieldValue
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue>, IReadOnlyList<Union<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue, BaseFunction>>, BaseFunction>? Defaults { get; set; }
        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-fields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Field
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.TaskTemplateTypes.Field>, IReadOnlyList<Union<Humidifier.Connect.TaskTemplateTypes.Field, BaseFunction>>, BaseFunction>? Fields { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// ContactFlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-contactflowarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContactFlowArn { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-clienttoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// SelfAssignContactFlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-selfassigncontactflowarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SelfAssignContactFlowArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-tasktemplate.html#cfn-connect-tasktemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TaskTemplateTypes
    {
        public class Constraints : Humidifier.Base.BaseSubResource, IHaveListOfConnectTaskTemplateTypesReadOnlyFieldInfoReadOnlyFields, IHaveListOfConnectTaskTemplateTypesInvisibleFieldInfoInvisibleFields, IHaveListOfConnectTaskTemplateTypesRequiredFieldInfoRequiredFields
        {
            /// <summary>
            /// ReadOnlyFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-constraints.html#cfn-connect-tasktemplate-constraints-readonlyfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReadOnlyFieldInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.TaskTemplateTypes.ReadOnlyFieldInfo>, IReadOnlyList<Union<Humidifier.Connect.TaskTemplateTypes.ReadOnlyFieldInfo, BaseFunction>>, BaseFunction>? ReadOnlyFields { get; set; }
            /// <summary>
            /// InvisibleFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-constraints.html#cfn-connect-tasktemplate-constraints-invisiblefields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InvisibleFieldInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.TaskTemplateTypes.InvisibleFieldInfo>, IReadOnlyList<Union<Humidifier.Connect.TaskTemplateTypes.InvisibleFieldInfo, BaseFunction>>, BaseFunction>? InvisibleFields { get; set; }
            /// <summary>
            /// RequiredFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-constraints.html#cfn-connect-tasktemplate-constraints-requiredfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RequiredFieldInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.TaskTemplateTypes.RequiredFieldInfo>, IReadOnlyList<Union<Humidifier.Connect.TaskTemplateTypes.RequiredFieldInfo, BaseFunction>>, BaseFunction>? RequiredFields { get; set; }
        }

        public class DefaultFieldValue : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveConnectTaskTemplateTypesFieldIdentifierId
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-defaultfieldvalue.html#cfn-connect-tasktemplate-defaultfieldvalue-defaultvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-defaultfieldvalue.html#cfn-connect-tasktemplate-defaultfieldvalue-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier, BaseFunction>? Id { get; set; }
        }

        public class Field : Humidifier.Base.BaseSubResource, IHaveType, IHaveDescription, IHaveConnectTaskTemplateTypesFieldIdentifierId, IHaveStringListOfSingleSelectOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier, BaseFunction>? Id { get; set; }
            /// <summary>
            /// SingleSelectOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-field.html#cfn-connect-tasktemplate-field-singleselectoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SingleSelectOptions { get; set; }
        }

        public class FieldIdentifier : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-fieldidentifier.html#cfn-connect-tasktemplate-fieldidentifier-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InvisibleFieldInfo : Humidifier.Base.BaseSubResource, IHaveConnectTaskTemplateTypesFieldIdentifierId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-invisiblefieldinfo.html#cfn-connect-tasktemplate-invisiblefieldinfo-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier, BaseFunction>? Id { get; set; }
        }

        public class ReadOnlyFieldInfo : Humidifier.Base.BaseSubResource, IHaveConnectTaskTemplateTypesFieldIdentifierId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-readonlyfieldinfo.html#cfn-connect-tasktemplate-readonlyfieldinfo-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier, BaseFunction>? Id { get; set; }
        }

        public class RequiredFieldInfo : Humidifier.Base.BaseSubResource, IHaveConnectTaskTemplateTypesFieldIdentifierId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-tasktemplate-requiredfieldinfo.html#cfn-connect-tasktemplate-requiredfieldinfo-id
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier, BaseFunction>? Id { get; set; }
        }
    }
}