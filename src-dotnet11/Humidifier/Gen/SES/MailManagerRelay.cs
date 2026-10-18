namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MailManagerRelayTypes;

    public class MailManagerRelay : Humidifier.Base.BaseResource, IHaveTags, IHaveSESMailManagerRelayTypesRelayAuthenticationAuthentication, IHaveServerName, IHaveRelayName, IHaveServerPort_Double
    {
        public class Attributes
        {
            public static string RelayId =  "RelayId" ;
            public static string RelayArn =  "RelayArn" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerRelay; }

        /// <summary>
        /// Authentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerrelay.html#cfn-ses-mailmanagerrelay-authentication
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RelayAuthentication
        /// </summary>
        [Required]
        public Union<Humidifier.SES.MailManagerRelayTypes.RelayAuthentication, BaseFunction>? Authentication { get; set; }

        /// <summary>
        /// ServerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerrelay.html#cfn-ses-mailmanagerrelay-servername
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServerName { get; set; }
        /// <summary>
        /// RelayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerrelay.html#cfn-ses-mailmanagerrelay-relayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RelayName { get; set; }

        /// <summary>
        /// ServerPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerrelay.html#cfn-ses-mailmanagerrelay-serverport
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? ServerPort { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerrelay.html#cfn-ses-mailmanagerrelay-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MailManagerRelayTypes
    {
        public class RelayAuthentication : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveNoAuthentication_Json
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerrelay-relayauthentication.html#cfn-ses-mailmanagerrelay-relayauthentication-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// NoAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerrelay-relayauthentication.html#cfn-ses-mailmanagerrelay-relayauthentication-noauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? NoAuthentication { get; set; }
        }
    }
}