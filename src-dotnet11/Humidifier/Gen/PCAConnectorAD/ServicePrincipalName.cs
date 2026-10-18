namespace Humidifier.PCAConnectorAD
{
    using global::System.Collections.Generic;

    public class ServicePrincipalName : Humidifier.Base.BaseResource, IHaveConnectorArn, IHaveDirectoryRegistrationArn
    {
        public override string AWSTypeName { get => AWS.PCAConnectorAD.ServicePrincipalName; }

        /// <summary>
        /// ConnectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-serviceprincipalname.html#cfn-pcaconnectorad-serviceprincipalname-connectorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectorArn { get; set; }

        /// <summary>
        /// DirectoryRegistrationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-serviceprincipalname.html#cfn-pcaconnectorad-serviceprincipalname-directoryregistrationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectoryRegistrationArn { get; set; }
    }
}