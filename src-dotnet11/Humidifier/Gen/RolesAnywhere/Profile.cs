namespace Humidifier.RolesAnywhere
{
    using global::System.Collections.Generic;
    using ProfileTypes;

    public class Profile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfManagedPolicyArns, IHaveRequireInstanceProperties_Boolean, IHaveStringListOfRoleArns, IHaveAcceptRoleSessionName_Boolean, IHaveSessionPolicy, IHaveListOfRolesAnywhereProfileTypesAttributeMappingAttributeMappings, IHaveEnabled_Boolean, IHaveDurationSeconds_Double, IHaveName
    {
        public class Attributes
        {
            public static string ProfileId =  "ProfileId" ;
            public static string ProfileArn =  "ProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.RolesAnywhere.Profile; }
        /// <summary>
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-managedpolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ManagedPolicyArns { get; set; }
        /// <summary>
        /// RequireInstanceProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-requireinstanceproperties
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RequireInstanceProperties { get; set; }

        /// <summary>
        /// RoleArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-rolearns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RoleArns { get; set; }
        /// <summary>
        /// AcceptRoleSessionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-acceptrolesessionname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AcceptRoleSessionName { get; set; }
        /// <summary>
        /// SessionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-sessionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SessionPolicy { get; set; }
        /// <summary>
        /// AttributeMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-attributemappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AttributeMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping>, IReadOnlyList<Union<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping, BaseFunction>>, BaseFunction>? AttributeMappings { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// DurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-durationseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? DurationSeconds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-profile.html#cfn-rolesanywhere-profile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ProfileTypes
    {
        public class AttributeMapping : Humidifier.Base.BaseSubResource, IHaveListOfRolesAnywhereProfileTypesMappingRuleMappingRules, IHaveCertificateField
        {
            /// <summary>
            /// MappingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-profile-attributemapping.html#cfn-rolesanywhere-profile-attributemapping-mappingrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappingRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RolesAnywhere.ProfileTypes.MappingRule>, IReadOnlyList<Union<Humidifier.RolesAnywhere.ProfileTypes.MappingRule, BaseFunction>>, BaseFunction>? MappingRules { get; set; }
            /// <summary>
            /// CertificateField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-profile-attributemapping.html#cfn-rolesanywhere-profile-attributemapping-certificatefield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateField { get; set; }
        }

        public class MappingRule : Humidifier.Base.BaseSubResource, IHaveSpecifier
        {
            /// <summary>
            /// Specifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-profile-mappingrule.html#cfn-rolesanywhere-profile-mappingrule-specifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Specifier { get; set; }
        }
    }
}