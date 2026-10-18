namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using EnvironmentActionsTypes;

    public class EnvironmentActions : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveEnvironmentIdentifier, IHaveIdentifier, IHaveDataZoneEnvironmentActionsTypesAwsConsoleLinkParametersParameters, IHaveDomainIdentifier, IHaveName
    {
        public class Attributes
        {
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string DomainId =  "DomainId" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.EnvironmentActions; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-environmentidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }
        /// <summary>
        /// Identifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-identifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Identifier { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AwsConsoleLinkParameters
        /// </summary>
        public Union<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-domainidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EnvironmentActionsTypes
    {
        public class AwsConsoleLinkParameters : Humidifier.Base.BaseSubResource, IHaveUri
        {
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environmentactions-awsconsolelinkparameters.html#cfn-datazone-environmentactions-awsconsolelinkparameters-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }
    }
}