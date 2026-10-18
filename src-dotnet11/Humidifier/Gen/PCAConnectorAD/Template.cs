namespace Humidifier.PCAConnectorAD
{
    using global::System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveConnectorArn, IHavePCAConnectorADTemplateTypesTemplateDefinitionDefinition, IHaveStringDictionaryOfTags, IHaveName, IHaveReenrollAllCertificateHolders_Boolean
    {
        public class Attributes
        {
            public static string TemplateArn =  "TemplateArn" ;
        }

        public override string AWSTypeName { get => AWS.PCAConnectorAD.Template; }

        /// <summary>
        /// ConnectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-connectorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectorArn { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TemplateDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReenrollAllCertificateHolders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-reenrollallcertificateholders
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReenrollAllCertificateHolders { get; set; }
    }

    namespace TemplateTypes
    {
        public class ApplicationPolicies : Humidifier.Base.BaseSubResource, IHaveCritical_Boolean, IHaveListOfPCAConnectorADTemplateTypesApplicationPolicyPolicies
        {
            /// <summary>
            /// Critical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicies.html#cfn-pcaconnectorad-template-applicationpolicies-critical
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Critical { get; set; }
            /// <summary>
            /// Policies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicies.html#cfn-pcaconnectorad-template-applicationpolicies-policies
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicy>, IReadOnlyList<Union<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicy, BaseFunction>>, BaseFunction>? Policies { get; set; }
        }

        public class ApplicationPolicy : Humidifier.Base.BaseSubResource, IHavePolicyType, IHavePolicyObjectIdentifier
        {
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicy.html#cfn-pcaconnectorad-template-applicationpolicy-policytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyType { get; set; }
            /// <summary>
            /// PolicyObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicy.html#cfn-pcaconnectorad-template-applicationpolicy-policyobjectidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyObjectIdentifier { get; set; }
        }

        public class CertificateValidity : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesValidityPeriodValidityPeriod, IHavePCAConnectorADTemplateTypesValidityPeriodRenewalPeriod
        {
            /// <summary>
            /// ValidityPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-certificatevalidity.html#cfn-pcaconnectorad-template-certificatevalidity-validityperiod
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ValidityPeriod
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod, BaseFunction>? ValidityPeriod { get; set; }
            /// <summary>
            /// RenewalPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-certificatevalidity.html#cfn-pcaconnectorad-template-certificatevalidity-renewalperiod
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ValidityPeriod
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod, BaseFunction>? RenewalPeriod { get; set; }
        }

        public class EnrollmentFlagsV2 : Humidifier.Base.BaseSubResource, IHaveNoSecurityExtension_Boolean, IHaveIncludeSymmetricAlgorithms_Boolean, IHaveUserInteractionRequired_Boolean, IHaveEnableKeyReuseOnNtTokenKeysetStorageFull_Boolean, IHaveRemoveInvalidCertificateFromPersonalStore_Boolean
        {
            /// <summary>
            /// NoSecurityExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-nosecurityextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoSecurityExtension { get; set; }
            /// <summary>
            /// IncludeSymmetricAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-includesymmetricalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSymmetricAlgorithms { get; set; }
            /// <summary>
            /// UserInteractionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-userinteractionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UserInteractionRequired { get; set; }
            /// <summary>
            /// EnableKeyReuseOnNtTokenKeysetStorageFull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-enablekeyreuseonnttokenkeysetstoragefull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
            /// <summary>
            /// RemoveInvalidCertificateFromPersonalStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-removeinvalidcertificatefrompersonalstore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemoveInvalidCertificateFromPersonalStore { get; set; }
        }

        public class EnrollmentFlagsV3 : Humidifier.Base.BaseSubResource, IHaveNoSecurityExtension_Boolean, IHaveIncludeSymmetricAlgorithms_Boolean, IHaveUserInteractionRequired_Boolean, IHaveEnableKeyReuseOnNtTokenKeysetStorageFull_Boolean, IHaveRemoveInvalidCertificateFromPersonalStore_Boolean
        {
            /// <summary>
            /// NoSecurityExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-nosecurityextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoSecurityExtension { get; set; }
            /// <summary>
            /// IncludeSymmetricAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-includesymmetricalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSymmetricAlgorithms { get; set; }
            /// <summary>
            /// UserInteractionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-userinteractionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UserInteractionRequired { get; set; }
            /// <summary>
            /// EnableKeyReuseOnNtTokenKeysetStorageFull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-enablekeyreuseonnttokenkeysetstoragefull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
            /// <summary>
            /// RemoveInvalidCertificateFromPersonalStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-removeinvalidcertificatefrompersonalstore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemoveInvalidCertificateFromPersonalStore { get; set; }
        }

        public class EnrollmentFlagsV4 : Humidifier.Base.BaseSubResource, IHaveNoSecurityExtension_Boolean, IHaveIncludeSymmetricAlgorithms_Boolean, IHaveUserInteractionRequired_Boolean, IHaveEnableKeyReuseOnNtTokenKeysetStorageFull_Boolean, IHaveRemoveInvalidCertificateFromPersonalStore_Boolean
        {
            /// <summary>
            /// NoSecurityExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-nosecurityextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoSecurityExtension { get; set; }
            /// <summary>
            /// IncludeSymmetricAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-includesymmetricalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSymmetricAlgorithms { get; set; }
            /// <summary>
            /// UserInteractionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-userinteractionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UserInteractionRequired { get; set; }
            /// <summary>
            /// EnableKeyReuseOnNtTokenKeysetStorageFull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-enablekeyreuseonnttokenkeysetstoragefull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
            /// <summary>
            /// RemoveInvalidCertificateFromPersonalStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-removeinvalidcertificatefrompersonalstore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemoveInvalidCertificateFromPersonalStore { get; set; }
        }

        public class ExtensionsV2 : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesApplicationPoliciesApplicationPolicies, IHavePCAConnectorADTemplateTypesKeyUsageKeyUsage
        {
            /// <summary>
            /// ApplicationPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv2.html#cfn-pcaconnectorad-template-extensionsv2-applicationpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationPolicies
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies, BaseFunction>? ApplicationPolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv2.html#cfn-pcaconnectorad-template-extensionsv2-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsage
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage, BaseFunction>? KeyUsage { get; set; }
        }

        public class ExtensionsV3 : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesApplicationPoliciesApplicationPolicies, IHavePCAConnectorADTemplateTypesKeyUsageKeyUsage
        {
            /// <summary>
            /// ApplicationPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv3.html#cfn-pcaconnectorad-template-extensionsv3-applicationpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationPolicies
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies, BaseFunction>? ApplicationPolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv3.html#cfn-pcaconnectorad-template-extensionsv3-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsage
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage, BaseFunction>? KeyUsage { get; set; }
        }

        public class ExtensionsV4 : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesApplicationPoliciesApplicationPolicies, IHavePCAConnectorADTemplateTypesKeyUsageKeyUsage
        {
            /// <summary>
            /// ApplicationPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv4.html#cfn-pcaconnectorad-template-extensionsv4-applicationpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationPolicies
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies, BaseFunction>? ApplicationPolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv4.html#cfn-pcaconnectorad-template-extensionsv4-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsage
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage, BaseFunction>? KeyUsage { get; set; }
        }

        public class GeneralFlagsV2 : Humidifier.Base.BaseSubResource, IHaveAutoEnrollment_Boolean, IHaveMachineType_Boolean
        {
            /// <summary>
            /// AutoEnrollment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv2.html#cfn-pcaconnectorad-template-generalflagsv2-autoenrollment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoEnrollment { get; set; }
            /// <summary>
            /// MachineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv2.html#cfn-pcaconnectorad-template-generalflagsv2-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MachineType { get; set; }
        }

        public class GeneralFlagsV3 : Humidifier.Base.BaseSubResource, IHaveAutoEnrollment_Boolean, IHaveMachineType_Boolean
        {
            /// <summary>
            /// AutoEnrollment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv3.html#cfn-pcaconnectorad-template-generalflagsv3-autoenrollment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoEnrollment { get; set; }
            /// <summary>
            /// MachineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv3.html#cfn-pcaconnectorad-template-generalflagsv3-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MachineType { get; set; }
        }

        public class GeneralFlagsV4 : Humidifier.Base.BaseSubResource, IHaveAutoEnrollment_Boolean, IHaveMachineType_Boolean
        {
            /// <summary>
            /// AutoEnrollment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv4.html#cfn-pcaconnectorad-template-generalflagsv4-autoenrollment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoEnrollment { get; set; }
            /// <summary>
            /// MachineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv4.html#cfn-pcaconnectorad-template-generalflagsv4-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MachineType { get; set; }
        }

        public class KeyUsage : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesKeyUsageFlagsUsageFlags, IHaveCritical_Boolean
        {
            /// <summary>
            /// UsageFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusage.html#cfn-pcaconnectorad-template-keyusage-usageflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsageFlags
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags, BaseFunction>? UsageFlags { get; set; }
            /// <summary>
            /// Critical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusage.html#cfn-pcaconnectorad-template-keyusage-critical
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Critical { get; set; }
        }

        public class KeyUsageFlags : Humidifier.Base.BaseSubResource, IHaveKeyEncipherment_Boolean, IHaveDataEncipherment_Boolean, IHaveDigitalSignature_Boolean, IHaveKeyAgreement_Boolean, IHaveNonRepudiation_Boolean
        {
            /// <summary>
            /// KeyEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-keyencipherment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyEncipherment { get; set; }
            /// <summary>
            /// DataEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-dataencipherment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataEncipherment { get; set; }
            /// <summary>
            /// DigitalSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-digitalsignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DigitalSignature { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-keyagreement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyAgreement { get; set; }
            /// <summary>
            /// NonRepudiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-nonrepudiation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NonRepudiation { get; set; }
        }

        public class KeyUsageProperty : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesKeyUsagePropertyFlagsPropertyFlags, IHavePropertyType
        {
            /// <summary>
            /// PropertyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageproperty.html#cfn-pcaconnectorad-template-keyusageproperty-propertyflags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyUsagePropertyFlags
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags, BaseFunction>? PropertyFlags { get; set; }
            /// <summary>
            /// PropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageproperty.html#cfn-pcaconnectorad-template-keyusageproperty-propertytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyType { get; set; }
        }

        public class KeyUsagePropertyFlags : Humidifier.Base.BaseSubResource, IHaveDecrypt_Boolean, IHaveSign_Boolean, IHaveKeyAgreement_Boolean
        {
            /// <summary>
            /// Decrypt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusagepropertyflags.html#cfn-pcaconnectorad-template-keyusagepropertyflags-decrypt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Decrypt { get; set; }
            /// <summary>
            /// Sign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusagepropertyflags.html#cfn-pcaconnectorad-template-keyusagepropertyflags-sign
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Sign { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusagepropertyflags.html#cfn-pcaconnectorad-template-keyusagepropertyflags-keyagreement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeyAgreement { get; set; }
        }

        public class PrivateKeyAttributesV2 : Humidifier.Base.BaseSubResource, IHaveMinimalKeyLength_Double, IHaveKeySpec, IHaveStringListOfCryptoProviders
        {
            /// <summary>
            /// MinimalKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv2.html#cfn-pcaconnectorad-template-privatekeyattributesv2-minimalkeylength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimalKeyLength { get; set; }
            /// <summary>
            /// KeySpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv2.html#cfn-pcaconnectorad-template-privatekeyattributesv2-keyspec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeySpec { get; set; }
            /// <summary>
            /// CryptoProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv2.html#cfn-pcaconnectorad-template-privatekeyattributesv2-cryptoproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CryptoProviders { get; set; }
        }

        public class PrivateKeyAttributesV3 : Humidifier.Base.BaseSubResource, IHaveMinimalKeyLength_Double, IHaveKeySpec, IHavePCAConnectorADTemplateTypesKeyUsagePropertyKeyUsageProperty, IHaveAlgorithm, IHaveStringListOfCryptoProviders
        {
            /// <summary>
            /// MinimalKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-minimalkeylength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimalKeyLength { get; set; }
            /// <summary>
            /// KeySpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-keyspec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeySpec { get; set; }
            /// <summary>
            /// KeyUsageProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-keyusageproperty
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsageProperty
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty, BaseFunction>? KeyUsageProperty { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-algorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// CryptoProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-cryptoproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CryptoProviders { get; set; }
        }

        public class PrivateKeyAttributesV4 : Humidifier.Base.BaseSubResource, IHaveMinimalKeyLength_Double, IHaveKeySpec, IHavePCAConnectorADTemplateTypesKeyUsagePropertyKeyUsageProperty, IHaveAlgorithm, IHaveStringListOfCryptoProviders
        {
            /// <summary>
            /// MinimalKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-minimalkeylength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimalKeyLength { get; set; }
            /// <summary>
            /// KeySpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-keyspec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeySpec { get; set; }
            /// <summary>
            /// KeyUsageProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-keyusageproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyUsageProperty
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty, BaseFunction>? KeyUsageProperty { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// CryptoProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-cryptoproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CryptoProviders { get; set; }
        }

        public class PrivateKeyFlagsV2 : Humidifier.Base.BaseSubResource, IHaveExportableKey_Boolean, IHaveStrongKeyProtectionRequired_Boolean, IHaveClientVersion
        {
            /// <summary>
            /// ExportableKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv2.html#cfn-pcaconnectorad-template-privatekeyflagsv2-exportablekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExportableKey { get; set; }
            /// <summary>
            /// StrongKeyProtectionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv2.html#cfn-pcaconnectorad-template-privatekeyflagsv2-strongkeyprotectionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StrongKeyProtectionRequired { get; set; }
            /// <summary>
            /// ClientVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv2.html#cfn-pcaconnectorad-template-privatekeyflagsv2-clientversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientVersion { get; set; }
        }

        public class PrivateKeyFlagsV3 : Humidifier.Base.BaseSubResource, IHaveRequireAlternateSignatureAlgorithm_Boolean, IHaveExportableKey_Boolean, IHaveStrongKeyProtectionRequired_Boolean, IHaveClientVersion
        {
            /// <summary>
            /// RequireAlternateSignatureAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-requirealternatesignaturealgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireAlternateSignatureAlgorithm { get; set; }
            /// <summary>
            /// ExportableKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-exportablekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExportableKey { get; set; }
            /// <summary>
            /// StrongKeyProtectionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-strongkeyprotectionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StrongKeyProtectionRequired { get; set; }
            /// <summary>
            /// ClientVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-clientversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientVersion { get; set; }
        }

        public class PrivateKeyFlagsV4 : Humidifier.Base.BaseSubResource, IHaveRequireAlternateSignatureAlgorithm_Boolean, IHaveExportableKey_Boolean, IHaveUseLegacyProvider_Boolean, IHaveStrongKeyProtectionRequired_Boolean, IHaveRequireSameKeyRenewal_Boolean, IHaveClientVersion
        {
            /// <summary>
            /// RequireAlternateSignatureAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-requirealternatesignaturealgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireAlternateSignatureAlgorithm { get; set; }
            /// <summary>
            /// ExportableKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-exportablekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExportableKey { get; set; }
            /// <summary>
            /// UseLegacyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-uselegacyprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseLegacyProvider { get; set; }
            /// <summary>
            /// StrongKeyProtectionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-strongkeyprotectionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StrongKeyProtectionRequired { get; set; }
            /// <summary>
            /// RequireSameKeyRenewal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-requiresamekeyrenewal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireSameKeyRenewal { get; set; }
            /// <summary>
            /// ClientVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-clientversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientVersion { get; set; }
        }

        public class SubjectNameFlagsV2 : Humidifier.Base.BaseSubResource, IHaveSanRequireEmail_Boolean, IHaveSanRequireDns_Boolean, IHaveRequireCommonName_Boolean, IHaveSanRequireUpn_Boolean, IHaveSanRequireDomainDns_Boolean, IHaveSanRequireSpn_Boolean, IHaveRequireEmail_Boolean, IHaveRequireDirectoryPath_Boolean, IHaveSanRequireDirectoryGuid_Boolean, IHaveRequireDnsAsCn_Boolean
        {
            /// <summary>
            /// SanRequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireEmail { get; set; }
            /// <summary>
            /// SanRequireDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequiredns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDns { get; set; }
            /// <summary>
            /// RequireCommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requirecommonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireCommonName { get; set; }
            /// <summary>
            /// SanRequireUpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequireupn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireUpn { get; set; }
            /// <summary>
            /// SanRequireDomainDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequiredomaindns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDomainDns { get; set; }
            /// <summary>
            /// SanRequireSpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequirespn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireSpn { get; set; }
            /// <summary>
            /// RequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireEmail { get; set; }
            /// <summary>
            /// RequireDirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requiredirectorypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireDirectoryPath { get; set; }
            /// <summary>
            /// SanRequireDirectoryGuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequiredirectoryguid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDirectoryGuid { get; set; }
            /// <summary>
            /// RequireDnsAsCn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requirednsascn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireDnsAsCn { get; set; }
        }

        public class SubjectNameFlagsV3 : Humidifier.Base.BaseSubResource, IHaveSanRequireEmail_Boolean, IHaveSanRequireDns_Boolean, IHaveRequireCommonName_Boolean, IHaveSanRequireUpn_Boolean, IHaveSanRequireDomainDns_Boolean, IHaveSanRequireSpn_Boolean, IHaveRequireEmail_Boolean, IHaveRequireDirectoryPath_Boolean, IHaveSanRequireDirectoryGuid_Boolean, IHaveRequireDnsAsCn_Boolean
        {
            /// <summary>
            /// SanRequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireEmail { get; set; }
            /// <summary>
            /// SanRequireDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequiredns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDns { get; set; }
            /// <summary>
            /// RequireCommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requirecommonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireCommonName { get; set; }
            /// <summary>
            /// SanRequireUpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequireupn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireUpn { get; set; }
            /// <summary>
            /// SanRequireDomainDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequiredomaindns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDomainDns { get; set; }
            /// <summary>
            /// SanRequireSpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequirespn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireSpn { get; set; }
            /// <summary>
            /// RequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireEmail { get; set; }
            /// <summary>
            /// RequireDirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requiredirectorypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireDirectoryPath { get; set; }
            /// <summary>
            /// SanRequireDirectoryGuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequiredirectoryguid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDirectoryGuid { get; set; }
            /// <summary>
            /// RequireDnsAsCn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requirednsascn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireDnsAsCn { get; set; }
        }

        public class SubjectNameFlagsV4 : Humidifier.Base.BaseSubResource, IHaveSanRequireEmail_Boolean, IHaveSanRequireDns_Boolean, IHaveRequireCommonName_Boolean, IHaveSanRequireUpn_Boolean, IHaveSanRequireDomainDns_Boolean, IHaveSanRequireSpn_Boolean, IHaveRequireEmail_Boolean, IHaveRequireDirectoryPath_Boolean, IHaveSanRequireDirectoryGuid_Boolean, IHaveRequireDnsAsCn_Boolean
        {
            /// <summary>
            /// SanRequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireEmail { get; set; }
            /// <summary>
            /// SanRequireDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequiredns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDns { get; set; }
            /// <summary>
            /// RequireCommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requirecommonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireCommonName { get; set; }
            /// <summary>
            /// SanRequireUpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequireupn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireUpn { get; set; }
            /// <summary>
            /// SanRequireDomainDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequiredomaindns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDomainDns { get; set; }
            /// <summary>
            /// SanRequireSpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequirespn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireSpn { get; set; }
            /// <summary>
            /// RequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireEmail { get; set; }
            /// <summary>
            /// RequireDirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requiredirectorypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireDirectoryPath { get; set; }
            /// <summary>
            /// SanRequireDirectoryGuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequiredirectoryguid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SanRequireDirectoryGuid { get; set; }
            /// <summary>
            /// RequireDnsAsCn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requirednsascn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireDnsAsCn { get; set; }
        }

        public class TemplateDefinition : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesTemplateV4TemplateV4, IHavePCAConnectorADTemplateTypesTemplateV3TemplateV3, IHavePCAConnectorADTemplateTypesTemplateV2TemplateV2
        {
            /// <summary>
            /// TemplateV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatedefinition.html#cfn-pcaconnectorad-template-templatedefinition-templatev4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.TemplateV4, BaseFunction>? TemplateV4 { get; set; }
            /// <summary>
            /// TemplateV3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatedefinition.html#cfn-pcaconnectorad-template-templatedefinition-templatev3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.TemplateV3, BaseFunction>? TemplateV3 { get; set; }
            /// <summary>
            /// TemplateV2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatedefinition.html#cfn-pcaconnectorad-template-templatedefinition-templatev2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.TemplateV2, BaseFunction>? TemplateV2 { get; set; }
        }

        public class TemplateV2 : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesSubjectNameFlagsV2SubjectNameFlags, IHaveStringListOfSupersededTemplates, IHavePCAConnectorADTemplateTypesPrivateKeyFlagsV2PrivateKeyFlags, IHavePCAConnectorADTemplateTypesPrivateKeyAttributesV2PrivateKeyAttributes, IHavePCAConnectorADTemplateTypesGeneralFlagsV2GeneralFlags, IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity, IHavePCAConnectorADTemplateTypesExtensionsV2Extensions, IHavePCAConnectorADTemplateTypesEnrollmentFlagsV2EnrollmentFlags
        {
            /// <summary>
            /// SubjectNameFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-subjectnameflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectNameFlagsV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2, BaseFunction>? SubjectNameFlags { get; set; }
            /// <summary>
            /// SupersededTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-supersededtemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupersededTemplates { get; set; }
            /// <summary>
            /// PrivateKeyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-privatekeyflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyFlagsV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2, BaseFunction>? PrivateKeyFlags { get; set; }
            /// <summary>
            /// PrivateKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-privatekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyAttributesV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2, BaseFunction>? PrivateKeyAttributes { get; set; }
            /// <summary>
            /// GeneralFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-generalflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeneralFlagsV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2, BaseFunction>? GeneralFlags { get; set; }
            /// <summary>
            /// CertificateValidity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-certificatevalidity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CertificateValidity
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity, BaseFunction>? CertificateValidity { get; set; }
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-extensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExtensionsV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2, BaseFunction>? Extensions { get; set; }
            /// <summary>
            /// EnrollmentFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-enrollmentflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrollmentFlagsV2
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2, BaseFunction>? EnrollmentFlags { get; set; }
        }

        public class TemplateV3 : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesSubjectNameFlagsV3SubjectNameFlags, IHaveStringListOfSupersededTemplates, IHavePCAConnectorADTemplateTypesPrivateKeyFlagsV3PrivateKeyFlags, IHavePCAConnectorADTemplateTypesPrivateKeyAttributesV3PrivateKeyAttributes, IHavePCAConnectorADTemplateTypesGeneralFlagsV3GeneralFlags, IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity, IHavePCAConnectorADTemplateTypesExtensionsV3Extensions, IHavePCAConnectorADTemplateTypesEnrollmentFlagsV3EnrollmentFlags, IHaveHashAlgorithm
        {
            /// <summary>
            /// SubjectNameFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-subjectnameflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectNameFlagsV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3, BaseFunction>? SubjectNameFlags { get; set; }
            /// <summary>
            /// SupersededTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-supersededtemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupersededTemplates { get; set; }
            /// <summary>
            /// PrivateKeyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-privatekeyflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyFlagsV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3, BaseFunction>? PrivateKeyFlags { get; set; }
            /// <summary>
            /// PrivateKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-privatekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyAttributesV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3, BaseFunction>? PrivateKeyAttributes { get; set; }
            /// <summary>
            /// GeneralFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-generalflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeneralFlagsV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3, BaseFunction>? GeneralFlags { get; set; }
            /// <summary>
            /// CertificateValidity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-certificatevalidity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CertificateValidity
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity, BaseFunction>? CertificateValidity { get; set; }
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-extensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExtensionsV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV3, BaseFunction>? Extensions { get; set; }
            /// <summary>
            /// EnrollmentFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-enrollmentflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrollmentFlagsV3
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3, BaseFunction>? EnrollmentFlags { get; set; }
            /// <summary>
            /// HashAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-hashalgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashAlgorithm { get; set; }
        }

        public class TemplateV4 : Humidifier.Base.BaseSubResource, IHavePCAConnectorADTemplateTypesSubjectNameFlagsV4SubjectNameFlags, IHaveStringListOfSupersededTemplates, IHavePCAConnectorADTemplateTypesPrivateKeyFlagsV4PrivateKeyFlags, IHavePCAConnectorADTemplateTypesPrivateKeyAttributesV4PrivateKeyAttributes, IHavePCAConnectorADTemplateTypesGeneralFlagsV4GeneralFlags, IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity, IHavePCAConnectorADTemplateTypesExtensionsV4Extensions, IHavePCAConnectorADTemplateTypesEnrollmentFlagsV4EnrollmentFlags, IHaveHashAlgorithm
        {
            /// <summary>
            /// SubjectNameFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-subjectnameflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectNameFlagsV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4, BaseFunction>? SubjectNameFlags { get; set; }
            /// <summary>
            /// SupersededTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-supersededtemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupersededTemplates { get; set; }
            /// <summary>
            /// PrivateKeyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-privatekeyflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyFlagsV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4, BaseFunction>? PrivateKeyFlags { get; set; }
            /// <summary>
            /// PrivateKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-privatekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyAttributesV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4, BaseFunction>? PrivateKeyAttributes { get; set; }
            /// <summary>
            /// GeneralFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-generalflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeneralFlagsV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4, BaseFunction>? GeneralFlags { get; set; }
            /// <summary>
            /// CertificateValidity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-certificatevalidity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CertificateValidity
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity, BaseFunction>? CertificateValidity { get; set; }
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-extensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExtensionsV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4, BaseFunction>? Extensions { get; set; }
            /// <summary>
            /// EnrollmentFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-enrollmentflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrollmentFlagsV4
            /// </summary>
            public Union<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4, BaseFunction>? EnrollmentFlags { get; set; }
            /// <summary>
            /// HashAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-hashalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashAlgorithm { get; set; }
        }

        public class ValidityPeriod : Humidifier.Base.BaseSubResource, IHavePeriodType, IHavePeriod_Double
        {
            /// <summary>
            /// PeriodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-validityperiod.html#cfn-pcaconnectorad-template-validityperiod-periodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PeriodType { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-validityperiod.html#cfn-pcaconnectorad-template-validityperiod-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Period { get; set; }
        }
    }
}