namespace Humidifier.DataZone
{
    using System.Collections.Generic;
    using EnvironmentActionsTypes;

    public class EnvironmentActions : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveIdentifier, IHaveDomainIdentifier, IHaveEnvironmentIdentifier
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
        public dynamic Description { get; set; }
        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-environmentidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentIdentifier { get; set; }
        /// <summary>
        /// Identifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-identifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Identifier { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AwsConsoleLinkParameters
        /// </summary>
        public Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters Parameters { get; set; }
        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentactions.html#cfn-datazone-environmentactions-domainidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainIdentifier { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Uri { get; set; }
        }
    }
}