namespace Humidifier.RolesAnywhere
{
    using global::System.Collections.Generic;
    using SubjectTypes;

    public class Subject : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string SubjectArn =  "SubjectArn" ;
            public static string LastSeenAt =  "LastSeenAt" ;
            public static string InstanceProperties =  "InstanceProperties" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string X509Subject =  "X509Subject" ;
            public static string SubjectId =  "SubjectId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Credentials =  "Credentials" ;
        }

        public override string AWSTypeName { get => AWS.RolesAnywhere.Subject; }
    }

    namespace SubjectTypes
    {
        public class CredentialSummary : Humidifier.Base.BaseSubResource, IHaveSerialNumber, IHaveIssuer, IHaveFailed_Boolean, IHaveX509CertificateData, IHaveSeenAt
        {
            /// <summary>
            /// SerialNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-credentialsummary.html#cfn-rolesanywhere-subject-credentialsummary-serialnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SerialNumber { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-credentialsummary.html#cfn-rolesanywhere-subject-credentialsummary-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// Failed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-credentialsummary.html#cfn-rolesanywhere-subject-credentialsummary-failed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Failed { get; set; }
            /// <summary>
            /// X509CertificateData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-credentialsummary.html#cfn-rolesanywhere-subject-credentialsummary-x509certificatedata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? X509CertificateData { get; set; }
            /// <summary>
            /// SeenAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-credentialsummary.html#cfn-rolesanywhere-subject-credentialsummary-seenat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SeenAt { get; set; }
        }

        public class InstanceProperty : Humidifier.Base.BaseSubResource, IHaveFailed_Boolean, IHaveStringDictionaryOfProperties, IHaveSeenAt
        {
            /// <summary>
            /// Failed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-instanceproperty.html#cfn-rolesanywhere-subject-instanceproperty-failed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Failed { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-instanceproperty.html#cfn-rolesanywhere-subject-instanceproperty-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// SeenAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-subject-instanceproperty.html#cfn-rolesanywhere-subject-instanceproperty-seenat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SeenAt { get; set; }
        }
    }
}