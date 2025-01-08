namespace Humidifier.SystemsManagerSAP
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags, IHaveApplicationId, IHaveInstances, IHaveSid
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SystemsManagerSAP.Application; }
        /// <summary>
        /// Instances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-instances
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Instances { get; set; }

        /// <summary>
        /// ApplicationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-applicationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationType { get; set; }
        /// <summary>
        /// DatabaseArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-databasearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatabaseArn { get; set; }
        /// <summary>
        /// SapInstanceNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-sapinstancenumber
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SapInstanceNumber { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-applicationid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationId { get; set; }
        /// <summary>
        /// Credentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-credentials
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Credential
        /// </summary>
        public List<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> Credentials { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Sid
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-systemsmanagersap-application.html#cfn-systemsmanagersap-application-sid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Sid { get; set; }
    }

    namespace ApplicationTypes
    {
        public class Credential : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveSecretId
        {
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-systemsmanagersap-application-credential.html#cfn-systemsmanagersap-application-credential-secretid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretId { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-systemsmanagersap-application-credential.html#cfn-systemsmanagersap-application-credential-databasename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CredentialType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-systemsmanagersap-application-credential.html#cfn-systemsmanagersap-application-credential-credentialtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialType { get; set; }
        }
    }
}