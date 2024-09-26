namespace Humidifier.VerifiedPermissions
{
    using System.Collections.Generic;
    using PolicyStoreTypes;

    public class PolicyStore : Humidifier.Base.BaseResource, IHaveDescription
    {
        public class Attributes
        {
            public static string PolicyStoreId =  "PolicyStoreId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VerifiedPermissions.PolicyStore; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ValidationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-validationsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ValidationSettings
        /// </summary>
        [Required]
        public Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings ValidationSettings { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-schema
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaDefinition
        /// </summary>
        public Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition Schema { get; set; }
    }

    namespace PolicyStoreTypes
    {
        public class SchemaDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CedarJson
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-schemadefinition.html#cfn-verifiedpermissions-policystore-schemadefinition-cedarjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CedarJson { get; set; }
        }

        public class ValidationSettings : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-validationsettings.html#cfn-verifiedpermissions-policystore-validationsettings-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }
    }
}