namespace Humidifier.PCAConnectorAD
{
    using System.Collections.Generic;

    public class ServicePrincipalName : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::PCAConnectorAD::ServicePrincipalName";
            }
        }

        /// <summary>
        /// ConnectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-serviceprincipalname.html#cfn-pcaconnectorad-serviceprincipalname-connectorarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectorArn { get; set; }
        /// <summary>
        /// DirectoryRegistrationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-serviceprincipalname.html#cfn-pcaconnectorad-serviceprincipalname-directoryregistrationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DirectoryRegistrationArn { get; set; }
    }
}