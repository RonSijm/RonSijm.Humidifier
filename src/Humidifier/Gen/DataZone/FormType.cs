namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using FormTypeTypes;

    public class FormType : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveStatus, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string DomainId =  "DomainId" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string Revision =  "Revision" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FormTypeIdentifier =  "FormTypeIdentifier" ;
            public static string OwningProjectId =  "OwningProjectId" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.FormType; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-formtype.html#cfn-datazone-formtype-status
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-formtype.html#cfn-datazone-formtype-description
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Model
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-formtype.html#cfn-datazone-formtype-model
        /// Required: True
        /// UpdateType: Conditional
        /// Type: Model
        /// </summary>
        [Required]
        public Humidifier.DataZone.FormTypeTypes.Model Model { get; set; }

        /// <summary>
        /// OwningProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-formtype.html#cfn-datazone-formtype-owningprojectidentifier
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OwningProjectIdentifier { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-formtype.html#cfn-datazone-formtype-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainIdentifier { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FormTypeTypes
    {
        public class Model : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Smithy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-formtype-model.html#cfn-datazone-formtype-model-smithy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Smithy { get; set; }
        }
    }
}