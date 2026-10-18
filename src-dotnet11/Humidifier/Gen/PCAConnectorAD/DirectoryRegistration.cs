namespace Humidifier.PCAConnectorAD
{
    using global::System.Collections.Generic;

    public class DirectoryRegistration : Humidifier.Base.BaseResource, IHaveDirectoryId, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string DirectoryRegistrationArn =  "DirectoryRegistrationArn" ;
        }

        public override string AWSTypeName { get => AWS.PCAConnectorAD.DirectoryRegistration; }

        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-directoryregistration.html#cfn-pcaconnectorad-directoryregistration-directoryid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectoryId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-directoryregistration.html#cfn-pcaconnectorad-directoryregistration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}