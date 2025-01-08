namespace Humidifier.PCAConnectorAD
{
    using System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveConnectorArn
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
        public dynamic ConnectorArn { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TemplateDefinition
        /// </summary>
        [Required]
        public Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition Definition { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReenrollAllCertificateHolders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-template.html#cfn-pcaconnectorad-template-reenrollallcertificateholders
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ReenrollAllCertificateHolders { get; set; }
    }

    namespace TemplateTypes
    {
        public class ApplicationPolicies : Humidifier.Base.BaseSubResource, IHaveCritical
        {
            /// <summary>
            /// Policies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicies.html#cfn-pcaconnectorad-template-applicationpolicies-policies
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationPolicy
            /// </summary>
            public List<Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicy> Policies { get; set; }
            /// <summary>
            /// Critical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicies.html#cfn-pcaconnectorad-template-applicationpolicies-critical
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Critical { get; set; }
        }

        public class ApplicationPolicy : Humidifier.Base.BaseSubResource, IHavePolicyType
        {
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicy.html#cfn-pcaconnectorad-template-applicationpolicy-policytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyType { get; set; }
            /// <summary>
            /// PolicyObjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-applicationpolicy.html#cfn-pcaconnectorad-template-applicationpolicy-policyobjectidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyObjectIdentifier { get; set; }
        }

        public class CertificateValidity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValidityPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-certificatevalidity.html#cfn-pcaconnectorad-template-certificatevalidity-validityperiod
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ValidityPeriod
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod ValidityPeriod { get; set; }
            /// <summary>
            /// RenewalPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-certificatevalidity.html#cfn-pcaconnectorad-template-certificatevalidity-renewalperiod
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ValidityPeriod
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod RenewalPeriod { get; set; }
        }

        public class EnrollmentFlagsV2 : Humidifier.Base.BaseSubResource, IHaveNoSecurityExtension, IHaveIncludeSymmetricAlgorithms, IHaveUserInteractionRequired, IHaveEnableKeyReuseOnNtTokenKeysetStorageFull, IHaveRemoveInvalidCertificateFromPersonalStore
        {
            /// <summary>
            /// NoSecurityExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-nosecurityextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NoSecurityExtension { get; set; }
            /// <summary>
            /// IncludeSymmetricAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-includesymmetricalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSymmetricAlgorithms { get; set; }
            /// <summary>
            /// UserInteractionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-userinteractionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UserInteractionRequired { get; set; }
            /// <summary>
            /// EnableKeyReuseOnNtTokenKeysetStorageFull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-enablekeyreuseonnttokenkeysetstoragefull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
            /// <summary>
            /// RemoveInvalidCertificateFromPersonalStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv2.html#cfn-pcaconnectorad-template-enrollmentflagsv2-removeinvalidcertificatefrompersonalstore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemoveInvalidCertificateFromPersonalStore { get; set; }
        }

        public class EnrollmentFlagsV3 : Humidifier.Base.BaseSubResource, IHaveNoSecurityExtension, IHaveIncludeSymmetricAlgorithms, IHaveUserInteractionRequired, IHaveEnableKeyReuseOnNtTokenKeysetStorageFull, IHaveRemoveInvalidCertificateFromPersonalStore
        {
            /// <summary>
            /// NoSecurityExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-nosecurityextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NoSecurityExtension { get; set; }
            /// <summary>
            /// IncludeSymmetricAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-includesymmetricalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSymmetricAlgorithms { get; set; }
            /// <summary>
            /// UserInteractionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-userinteractionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UserInteractionRequired { get; set; }
            /// <summary>
            /// EnableKeyReuseOnNtTokenKeysetStorageFull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-enablekeyreuseonnttokenkeysetstoragefull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
            /// <summary>
            /// RemoveInvalidCertificateFromPersonalStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv3.html#cfn-pcaconnectorad-template-enrollmentflagsv3-removeinvalidcertificatefrompersonalstore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemoveInvalidCertificateFromPersonalStore { get; set; }
        }

        public class EnrollmentFlagsV4 : Humidifier.Base.BaseSubResource, IHaveNoSecurityExtension, IHaveIncludeSymmetricAlgorithms, IHaveUserInteractionRequired, IHaveEnableKeyReuseOnNtTokenKeysetStorageFull, IHaveRemoveInvalidCertificateFromPersonalStore
        {
            /// <summary>
            /// NoSecurityExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-nosecurityextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NoSecurityExtension { get; set; }
            /// <summary>
            /// IncludeSymmetricAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-includesymmetricalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSymmetricAlgorithms { get; set; }
            /// <summary>
            /// UserInteractionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-userinteractionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UserInteractionRequired { get; set; }
            /// <summary>
            /// EnableKeyReuseOnNtTokenKeysetStorageFull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-enablekeyreuseonnttokenkeysetstoragefull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableKeyReuseOnNtTokenKeysetStorageFull { get; set; }
            /// <summary>
            /// RemoveInvalidCertificateFromPersonalStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-enrollmentflagsv4.html#cfn-pcaconnectorad-template-enrollmentflagsv4-removeinvalidcertificatefrompersonalstore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemoveInvalidCertificateFromPersonalStore { get; set; }
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
            public Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies ApplicationPolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv2.html#cfn-pcaconnectorad-template-extensionsv2-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsage
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage KeyUsage { get; set; }
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
            public Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies ApplicationPolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv3.html#cfn-pcaconnectorad-template-extensionsv3-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsage
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage KeyUsage { get; set; }
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
            public Humidifier.PCAConnectorAD.TemplateTypes.ApplicationPolicies ApplicationPolicies { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-extensionsv4.html#cfn-pcaconnectorad-template-extensionsv4-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsage
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsage KeyUsage { get; set; }
        }

        public class GeneralFlagsV2 : Humidifier.Base.BaseSubResource, IHaveAutoEnrollment, IHaveMachineType
        {
            /// <summary>
            /// AutoEnrollment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv2.html#cfn-pcaconnectorad-template-generalflagsv2-autoenrollment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoEnrollment { get; set; }
            /// <summary>
            /// MachineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv2.html#cfn-pcaconnectorad-template-generalflagsv2-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MachineType { get; set; }
        }

        public class GeneralFlagsV3 : Humidifier.Base.BaseSubResource, IHaveAutoEnrollment, IHaveMachineType
        {
            /// <summary>
            /// AutoEnrollment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv3.html#cfn-pcaconnectorad-template-generalflagsv3-autoenrollment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoEnrollment { get; set; }
            /// <summary>
            /// MachineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv3.html#cfn-pcaconnectorad-template-generalflagsv3-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MachineType { get; set; }
        }

        public class GeneralFlagsV4 : Humidifier.Base.BaseSubResource, IHaveAutoEnrollment, IHaveMachineType
        {
            /// <summary>
            /// AutoEnrollment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv4.html#cfn-pcaconnectorad-template-generalflagsv4-autoenrollment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoEnrollment { get; set; }
            /// <summary>
            /// MachineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-generalflagsv4.html#cfn-pcaconnectorad-template-generalflagsv4-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MachineType { get; set; }
        }

        public class KeyUsage : Humidifier.Base.BaseSubResource, IHaveCritical
        {
            /// <summary>
            /// Critical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusage.html#cfn-pcaconnectorad-template-keyusage-critical
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Critical { get; set; }
            /// <summary>
            /// UsageFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusage.html#cfn-pcaconnectorad-template-keyusage-usageflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsageFlags
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags UsageFlags { get; set; }
        }

        public class KeyUsageFlags : Humidifier.Base.BaseSubResource, IHaveKeyAgreement, IHaveKeyEncipherment, IHaveDataEncipherment, IHaveDigitalSignature, IHaveNonRepudiation
        {
            /// <summary>
            /// KeyEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-keyencipherment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic KeyEncipherment { get; set; }
            /// <summary>
            /// DataEncipherment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-dataencipherment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataEncipherment { get; set; }
            /// <summary>
            /// DigitalSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-digitalsignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DigitalSignature { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-keyagreement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic KeyAgreement { get; set; }
            /// <summary>
            /// NonRepudiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageflags.html#cfn-pcaconnectorad-template-keyusageflags-nonrepudiation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NonRepudiation { get; set; }
        }

        public class KeyUsageProperty : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PropertyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageproperty.html#cfn-pcaconnectorad-template-keyusageproperty-propertyflags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyUsagePropertyFlags
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags PropertyFlags { get; set; }
            /// <summary>
            /// PropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusageproperty.html#cfn-pcaconnectorad-template-keyusageproperty-propertytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyType { get; set; }
        }

        public class KeyUsagePropertyFlags : Humidifier.Base.BaseSubResource, IHaveKeyAgreement, IHaveDecrypt, IHaveSign
        {
            /// <summary>
            /// Decrypt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusagepropertyflags.html#cfn-pcaconnectorad-template-keyusagepropertyflags-decrypt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Decrypt { get; set; }
            /// <summary>
            /// Sign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusagepropertyflags.html#cfn-pcaconnectorad-template-keyusagepropertyflags-sign
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Sign { get; set; }
            /// <summary>
            /// KeyAgreement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-keyusagepropertyflags.html#cfn-pcaconnectorad-template-keyusagepropertyflags-keyagreement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic KeyAgreement { get; set; }
        }

        public class PrivateKeyAttributesV2 : Humidifier.Base.BaseSubResource, IHaveKeySpec, IHaveMinimalKeyLength, IHaveCryptoProviders
        {
            /// <summary>
            /// MinimalKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv2.html#cfn-pcaconnectorad-template-privatekeyattributesv2-minimalkeylength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimalKeyLength { get; set; }
            /// <summary>
            /// KeySpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv2.html#cfn-pcaconnectorad-template-privatekeyattributesv2-keyspec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeySpec { get; set; }
            /// <summary>
            /// CryptoProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv2.html#cfn-pcaconnectorad-template-privatekeyattributesv2-cryptoproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CryptoProviders { get; set; }
        }

        public class PrivateKeyAttributesV3 : Humidifier.Base.BaseSubResource, IHaveAlgorithm, IHaveKeySpec, IHaveMinimalKeyLength, IHaveCryptoProviders, IHavePCAConnectorADTemplateTypesKeyUsagePropertyKeyUsageProperty
        {
            /// <summary>
            /// MinimalKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-minimalkeylength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimalKeyLength { get; set; }
            /// <summary>
            /// KeySpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-keyspec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeySpec { get; set; }
            /// <summary>
            /// KeyUsageProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-keyusageproperty
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyUsageProperty
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty KeyUsageProperty { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-algorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// CryptoProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv3.html#cfn-pcaconnectorad-template-privatekeyattributesv3-cryptoproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CryptoProviders { get; set; }
        }

        public class PrivateKeyAttributesV4 : Humidifier.Base.BaseSubResource, IHaveAlgorithm, IHaveKeySpec, IHaveMinimalKeyLength, IHaveCryptoProviders, IHavePCAConnectorADTemplateTypesKeyUsagePropertyKeyUsageProperty
        {
            /// <summary>
            /// MinimalKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-minimalkeylength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimalKeyLength { get; set; }
            /// <summary>
            /// KeySpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-keyspec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeySpec { get; set; }
            /// <summary>
            /// KeyUsageProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-keyusageproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyUsageProperty
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageProperty KeyUsageProperty { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// CryptoProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyattributesv4.html#cfn-pcaconnectorad-template-privatekeyattributesv4-cryptoproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CryptoProviders { get; set; }
        }

        public class PrivateKeyFlagsV2 : Humidifier.Base.BaseSubResource, IHaveExportableKey, IHaveStrongKeyProtectionRequired, IHaveClientVersion
        {
            /// <summary>
            /// ExportableKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv2.html#cfn-pcaconnectorad-template-privatekeyflagsv2-exportablekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ExportableKey { get; set; }
            /// <summary>
            /// StrongKeyProtectionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv2.html#cfn-pcaconnectorad-template-privatekeyflagsv2-strongkeyprotectionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StrongKeyProtectionRequired { get; set; }
            /// <summary>
            /// ClientVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv2.html#cfn-pcaconnectorad-template-privatekeyflagsv2-clientversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientVersion { get; set; }
        }

        public class PrivateKeyFlagsV3 : Humidifier.Base.BaseSubResource, IHaveExportableKey, IHaveStrongKeyProtectionRequired, IHaveClientVersion, IHaveRequireAlternateSignatureAlgorithm
        {
            /// <summary>
            /// RequireAlternateSignatureAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-requirealternatesignaturealgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireAlternateSignatureAlgorithm { get; set; }
            /// <summary>
            /// ExportableKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-exportablekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ExportableKey { get; set; }
            /// <summary>
            /// StrongKeyProtectionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-strongkeyprotectionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StrongKeyProtectionRequired { get; set; }
            /// <summary>
            /// ClientVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv3.html#cfn-pcaconnectorad-template-privatekeyflagsv3-clientversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientVersion { get; set; }
        }

        public class PrivateKeyFlagsV4 : Humidifier.Base.BaseSubResource, IHaveExportableKey, IHaveStrongKeyProtectionRequired, IHaveClientVersion, IHaveRequireAlternateSignatureAlgorithm
        {
            /// <summary>
            /// RequireAlternateSignatureAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-requirealternatesignaturealgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireAlternateSignatureAlgorithm { get; set; }
            /// <summary>
            /// ExportableKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-exportablekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ExportableKey { get; set; }
            /// <summary>
            /// UseLegacyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-uselegacyprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseLegacyProvider { get; set; }
            /// <summary>
            /// StrongKeyProtectionRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-strongkeyprotectionrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StrongKeyProtectionRequired { get; set; }
            /// <summary>
            /// RequireSameKeyRenewal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-requiresamekeyrenewal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireSameKeyRenewal { get; set; }
            /// <summary>
            /// ClientVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-privatekeyflagsv4.html#cfn-pcaconnectorad-template-privatekeyflagsv4-clientversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientVersion { get; set; }
        }

        public class SubjectNameFlagsV2 : Humidifier.Base.BaseSubResource, IHaveSanRequireEmail, IHaveSanRequireDns, IHaveRequireCommonName, IHaveSanRequireUpn, IHaveSanRequireDomainDns, IHaveSanRequireSpn, IHaveRequireEmail, IHaveRequireDirectoryPath, IHaveSanRequireDirectoryGuid, IHaveRequireDnsAsCn
        {
            /// <summary>
            /// SanRequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireEmail { get; set; }
            /// <summary>
            /// SanRequireDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequiredns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDns { get; set; }
            /// <summary>
            /// RequireCommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requirecommonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireCommonName { get; set; }
            /// <summary>
            /// SanRequireUpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequireupn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireUpn { get; set; }
            /// <summary>
            /// SanRequireDomainDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequiredomaindns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDomainDns { get; set; }
            /// <summary>
            /// SanRequireSpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequirespn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireSpn { get; set; }
            /// <summary>
            /// RequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireEmail { get; set; }
            /// <summary>
            /// RequireDirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requiredirectorypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireDirectoryPath { get; set; }
            /// <summary>
            /// SanRequireDirectoryGuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-sanrequiredirectoryguid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDirectoryGuid { get; set; }
            /// <summary>
            /// RequireDnsAsCn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv2.html#cfn-pcaconnectorad-template-subjectnameflagsv2-requirednsascn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireDnsAsCn { get; set; }
        }

        public class SubjectNameFlagsV3 : Humidifier.Base.BaseSubResource, IHaveSanRequireEmail, IHaveSanRequireDns, IHaveRequireCommonName, IHaveSanRequireUpn, IHaveSanRequireDomainDns, IHaveSanRequireSpn, IHaveRequireEmail, IHaveRequireDirectoryPath, IHaveSanRequireDirectoryGuid, IHaveRequireDnsAsCn
        {
            /// <summary>
            /// SanRequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireEmail { get; set; }
            /// <summary>
            /// SanRequireDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequiredns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDns { get; set; }
            /// <summary>
            /// RequireCommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requirecommonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireCommonName { get; set; }
            /// <summary>
            /// SanRequireUpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequireupn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireUpn { get; set; }
            /// <summary>
            /// SanRequireDomainDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequiredomaindns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDomainDns { get; set; }
            /// <summary>
            /// SanRequireSpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequirespn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireSpn { get; set; }
            /// <summary>
            /// RequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireEmail { get; set; }
            /// <summary>
            /// RequireDirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requiredirectorypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireDirectoryPath { get; set; }
            /// <summary>
            /// SanRequireDirectoryGuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-sanrequiredirectoryguid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDirectoryGuid { get; set; }
            /// <summary>
            /// RequireDnsAsCn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv3.html#cfn-pcaconnectorad-template-subjectnameflagsv3-requirednsascn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireDnsAsCn { get; set; }
        }

        public class SubjectNameFlagsV4 : Humidifier.Base.BaseSubResource, IHaveSanRequireEmail, IHaveSanRequireDns, IHaveRequireCommonName, IHaveSanRequireUpn, IHaveSanRequireDomainDns, IHaveSanRequireSpn, IHaveRequireEmail, IHaveRequireDirectoryPath, IHaveSanRequireDirectoryGuid, IHaveRequireDnsAsCn
        {
            /// <summary>
            /// SanRequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireEmail { get; set; }
            /// <summary>
            /// SanRequireDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequiredns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDns { get; set; }
            /// <summary>
            /// RequireCommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requirecommonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireCommonName { get; set; }
            /// <summary>
            /// SanRequireUpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequireupn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireUpn { get; set; }
            /// <summary>
            /// SanRequireDomainDns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequiredomaindns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDomainDns { get; set; }
            /// <summary>
            /// SanRequireSpn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequirespn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireSpn { get; set; }
            /// <summary>
            /// RequireEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requireemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireEmail { get; set; }
            /// <summary>
            /// RequireDirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requiredirectorypath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireDirectoryPath { get; set; }
            /// <summary>
            /// SanRequireDirectoryGuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-sanrequiredirectoryguid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SanRequireDirectoryGuid { get; set; }
            /// <summary>
            /// RequireDnsAsCn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-subjectnameflagsv4.html#cfn-pcaconnectorad-template-subjectnameflagsv4-requirednsascn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireDnsAsCn { get; set; }
        }

        public class TemplateDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TemplateV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatedefinition.html#cfn-pcaconnectorad-template-templatedefinition-templatev4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.TemplateV4 TemplateV4 { get; set; }
            /// <summary>
            /// TemplateV3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatedefinition.html#cfn-pcaconnectorad-template-templatedefinition-templatev3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.TemplateV3 TemplateV3 { get; set; }
            /// <summary>
            /// TemplateV2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatedefinition.html#cfn-pcaconnectorad-template-templatedefinition-templatev2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.TemplateV2 TemplateV2 { get; set; }
        }

        public class TemplateV2 : Humidifier.Base.BaseSubResource, IHaveSupersededTemplates, IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity
        {
            /// <summary>
            /// SubjectNameFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-subjectnameflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectNameFlagsV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2 SubjectNameFlags { get; set; }
            /// <summary>
            /// SupersededTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-supersededtemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupersededTemplates { get; set; }
            /// <summary>
            /// PrivateKeyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-privatekeyflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyFlagsV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2 PrivateKeyFlags { get; set; }
            /// <summary>
            /// PrivateKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-privatekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyAttributesV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2 PrivateKeyAttributes { get; set; }
            /// <summary>
            /// GeneralFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-generalflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeneralFlagsV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2 GeneralFlags { get; set; }
            /// <summary>
            /// CertificateValidity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-certificatevalidity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CertificateValidity
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity CertificateValidity { get; set; }
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-extensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExtensionsV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV2 Extensions { get; set; }
            /// <summary>
            /// EnrollmentFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev2.html#cfn-pcaconnectorad-template-templatev2-enrollmentflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrollmentFlagsV2
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2 EnrollmentFlags { get; set; }
        }

        public class TemplateV3 : Humidifier.Base.BaseSubResource, IHaveSupersededTemplates, IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity, IHaveHashAlgorithm
        {
            /// <summary>
            /// SubjectNameFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-subjectnameflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectNameFlagsV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3 SubjectNameFlags { get; set; }
            /// <summary>
            /// SupersededTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-supersededtemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupersededTemplates { get; set; }
            /// <summary>
            /// PrivateKeyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-privatekeyflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyFlagsV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3 PrivateKeyFlags { get; set; }
            /// <summary>
            /// PrivateKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-privatekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyAttributesV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV3 PrivateKeyAttributes { get; set; }
            /// <summary>
            /// GeneralFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-generalflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeneralFlagsV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3 GeneralFlags { get; set; }
            /// <summary>
            /// CertificateValidity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-certificatevalidity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CertificateValidity
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity CertificateValidity { get; set; }
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-extensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExtensionsV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV3 Extensions { get; set; }
            /// <summary>
            /// EnrollmentFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-enrollmentflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrollmentFlagsV3
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3 EnrollmentFlags { get; set; }
            /// <summary>
            /// HashAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev3.html#cfn-pcaconnectorad-template-templatev3-hashalgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HashAlgorithm { get; set; }
        }

        public class TemplateV4 : Humidifier.Base.BaseSubResource, IHaveSupersededTemplates, IHavePCAConnectorADTemplateTypesCertificateValidityCertificateValidity, IHaveHashAlgorithm
        {
            /// <summary>
            /// SubjectNameFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-subjectnameflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectNameFlagsV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4 SubjectNameFlags { get; set; }
            /// <summary>
            /// SupersededTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-supersededtemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupersededTemplates { get; set; }
            /// <summary>
            /// PrivateKeyFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-privatekeyflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyFlagsV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4 PrivateKeyFlags { get; set; }
            /// <summary>
            /// PrivateKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-privatekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateKeyAttributesV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV4 PrivateKeyAttributes { get; set; }
            /// <summary>
            /// GeneralFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-generalflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeneralFlagsV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4 GeneralFlags { get; set; }
            /// <summary>
            /// CertificateValidity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-certificatevalidity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CertificateValidity
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity CertificateValidity { get; set; }
            /// <summary>
            /// Extensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-extensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExtensionsV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.ExtensionsV4 Extensions { get; set; }
            /// <summary>
            /// EnrollmentFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-enrollmentflags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrollmentFlagsV4
            /// </summary>
            public Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4 EnrollmentFlags { get; set; }
            /// <summary>
            /// HashAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-templatev4.html#cfn-pcaconnectorad-template-templatev4-hashalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HashAlgorithm { get; set; }
        }

        public class ValidityPeriod : Humidifier.Base.BaseSubResource, IHavePeriod
        {
            /// <summary>
            /// PeriodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-validityperiod.html#cfn-pcaconnectorad-template-validityperiod-periodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeriodType { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-template-validityperiod.html#cfn-pcaconnectorad-template-validityperiod-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Period { get; set; }
        }
    }
}