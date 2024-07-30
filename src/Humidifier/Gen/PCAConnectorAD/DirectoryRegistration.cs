namespace Humidifier.PCAConnectorAD
{
    using System.Collections.Generic;

    public class DirectoryRegistration : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string DirectoryRegistrationArn =  "DirectoryRegistrationArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::PCAConnectorAD::DirectoryRegistration";
            }
        }

        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-directoryregistration.html#cfn-pcaconnectorad-directoryregistration-directoryid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DirectoryId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-directoryregistration.html#cfn-pcaconnectorad-directoryregistration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}