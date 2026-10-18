namespace Humidifier.FinSpace
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyId, IHaveFinSpaceEnvironmentTypesFederationParametersFederationParameters, IHaveFederationMode, IHaveFinSpaceEnvironmentTypesSuperuserParametersSuperuserParameters, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string EnvironmentArn =  "EnvironmentArn" ;
            public static string SageMakerStudioDomainUrl =  "SageMakerStudioDomainUrl" ;
            public static string EnvironmentUrl =  "EnvironmentUrl" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string DedicatedServiceAccountId =  "DedicatedServiceAccountId" ;
        }

        public override string AWSTypeName { get => AWS.FinSpace.Environment; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// FederationParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-federationparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: FederationParameters
        /// </summary>
        public Union<Humidifier.FinSpace.EnvironmentTypes.FederationParameters, BaseFunction>? FederationParameters { get; set; }
        /// <summary>
        /// FederationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-federationmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FederationMode { get; set; }
        /// <summary>
        /// SuperuserParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-superuserparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SuperuserParameters
        /// </summary>
        public Union<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters, BaseFunction>? SuperuserParameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EnvironmentTypes
    {
        public class AttributeMapItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-attributemapitems.html#cfn-finspace-environment-attributemapitems-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-attributemapitems.html#cfn-finspace-environment-attributemapitems-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class FederationParameters : Humidifier.Base.BaseSubResource, IHaveListOfFinSpaceEnvironmentTypesAttributeMapItemsAttributeMap, IHaveFederationProviderName, IHaveSamlMetadataURL, IHaveFederationURN, IHaveSamlMetadataDocument, IHaveApplicationCallBackURL
        {
            /// <summary>
            /// AttributeMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html#cfn-finspace-environment-federationparameters-attributemap
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AttributeMapItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FinSpace.EnvironmentTypes.AttributeMapItems>, IReadOnlyList<Union<Humidifier.FinSpace.EnvironmentTypes.AttributeMapItems, BaseFunction>>, BaseFunction>? AttributeMap { get; set; }
            /// <summary>
            /// FederationProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html#cfn-finspace-environment-federationparameters-federationprovidername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FederationProviderName { get; set; }
            /// <summary>
            /// SamlMetadataURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html#cfn-finspace-environment-federationparameters-samlmetadataurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SamlMetadataURL { get; set; }
            /// <summary>
            /// FederationURN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html#cfn-finspace-environment-federationparameters-federationurn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FederationURN { get; set; }
            /// <summary>
            /// SamlMetadataDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html#cfn-finspace-environment-federationparameters-samlmetadatadocument
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SamlMetadataDocument { get; set; }
            /// <summary>
            /// ApplicationCallBackURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html#cfn-finspace-environment-federationparameters-applicationcallbackurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationCallBackURL { get; set; }
        }

        public class SuperuserParameters : Humidifier.Base.BaseSubResource, IHaveFirstName, IHaveLastName, IHaveEmailAddress
        {
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-superuserparameters.html#cfn-finspace-environment-superuserparameters-firstname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirstName { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-superuserparameters.html#cfn-finspace-environment-superuserparameters-lastname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastName { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-superuserparameters.html#cfn-finspace-environment-superuserparameters-emailaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailAddress { get; set; }
        }
    }
}