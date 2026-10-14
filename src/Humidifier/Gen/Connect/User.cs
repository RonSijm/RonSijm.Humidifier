namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using UserTypes;

    public class User : Humidifier.Base.BaseResource, IHaveTags, IHaveUsername, IHavePassword, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string UserArn =  "UserArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.User; }
        /// <summary>
        /// AfterContactWorkConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-aftercontactworkconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AfterContactWorkConfigPerChannel
        /// </summary>
        public List<Humidifier.Connect.UserTypes.AfterContactWorkConfigPerChannel> AfterContactWorkConfigs { get; set; }

        /// <summary>
        /// RoutingProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-routingprofilearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoutingProfileArn { get; set; }
        /// <summary>
        /// PhoneConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-phoneconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserPhoneConfig
        /// </summary>
        public Humidifier.Connect.UserTypes.UserPhoneConfig PhoneConfig { get; set; }
        /// <summary>
        /// DirectoryUserId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-directoryuserid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DirectoryUserId { get; set; }
        /// <summary>
        /// HierarchyGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-hierarchygrouparn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HierarchyGroupArn { get; set; }
        /// <summary>
        /// PersistentConnectionConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-persistentconnectionconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PersistentConnectionConfig
        /// </summary>
        public List<Humidifier.Connect.UserTypes.PersistentConnectionConfig> PersistentConnectionConfigs { get; set; }
        /// <summary>
        /// UserProficiencies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-userproficiencies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: UserProficiency
        /// </summary>
        public List<Humidifier.Connect.UserTypes.UserProficiency> UserProficiencies { get; set; }
        /// <summary>
        /// VoiceEnhancementConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-voiceenhancementconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VoiceEnhancementConfig
        /// </summary>
        public List<Humidifier.Connect.UserTypes.VoiceEnhancementConfig> VoiceEnhancementConfigs { get; set; }
        /// <summary>
        /// PhoneNumberConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-phonenumberconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PhoneNumberConfig
        /// </summary>
        public List<Humidifier.Connect.UserTypes.PhoneNumberConfig> PhoneNumberConfigs { get; set; }

        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-username
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Username { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// IdentityInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-identityinfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserIdentityInfo
        /// </summary>
        public Humidifier.Connect.UserTypes.UserIdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// SecurityProfileArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-securityprofilearns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SecurityProfileArns { get; set; }
        /// <summary>
        /// AutoAcceptConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-autoacceptconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AutoAcceptConfig
        /// </summary>
        public List<Humidifier.Connect.UserTypes.AutoAcceptConfig> AutoAcceptConfigs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-user.html#cfn-connect-user-password
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Password { get; set; }
    }

    namespace UserTypes
    {
        public class AfterContactWorkConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AfterContactWorkMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-aftercontactworkconfig.html#cfn-connect-user-aftercontactworkconfig-aftercontactworkmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AfterContactWorkMode { get; set; }
            /// <summary>
            /// AfterContactWorkTimeLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-aftercontactworkconfig.html#cfn-connect-user-aftercontactworkconfig-aftercontactworktimelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AfterContactWorkTimeLimit { get; set; }
        }

        public class AfterContactWorkConfigPerChannel : Humidifier.Base.BaseSubResource, IHaveChannel
        {
            /// <summary>
            /// AfterContactWorkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-aftercontactworkconfigperchannel.html#cfn-connect-user-aftercontactworkconfigperchannel-aftercontactworkconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AfterContactWorkConfig
            /// </summary>
            public Humidifier.Connect.UserTypes.AfterContactWorkConfig AfterContactWorkConfig { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-aftercontactworkconfigperchannel.html#cfn-connect-user-aftercontactworkconfigperchannel-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
            /// <summary>
            /// AgentFirstCallbackAfterContactWorkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-aftercontactworkconfigperchannel.html#cfn-connect-user-aftercontactworkconfigperchannel-agentfirstcallbackaftercontactworkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AfterContactWorkConfig
            /// </summary>
            public Humidifier.Connect.UserTypes.AfterContactWorkConfig AgentFirstCallbackAfterContactWorkConfig { get; set; }
        }

        public class AutoAcceptConfig : Humidifier.Base.BaseSubResource, IHaveChannel
        {
            /// <summary>
            /// AutoAccept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-autoacceptconfig.html#cfn-connect-user-autoacceptconfig-autoaccept
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoAccept { get; set; }
            /// <summary>
            /// AgentFirstCallbackAutoAccept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-autoacceptconfig.html#cfn-connect-user-autoacceptconfig-agentfirstcallbackautoaccept
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AgentFirstCallbackAutoAccept { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-autoacceptconfig.html#cfn-connect-user-autoacceptconfig-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
        }

        public class PersistentConnectionConfig : Humidifier.Base.BaseSubResource, IHaveChannel
        {
            /// <summary>
            /// PersistentConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-persistentconnectionconfig.html#cfn-connect-user-persistentconnectionconfig-persistentconnection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PersistentConnection { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-persistentconnectionconfig.html#cfn-connect-user-persistentconnectionconfig-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
        }

        public class PhoneNumberConfig : Humidifier.Base.BaseSubResource, IHavePhoneNumber, IHaveChannel
        {
            /// <summary>
            /// PhoneType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-phonenumberconfig.html#cfn-connect-user-phonenumberconfig-phonetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhoneType { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-phonenumberconfig.html#cfn-connect-user-phonenumberconfig-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-phonenumberconfig.html#cfn-connect-user-phonenumberconfig-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhoneNumber { get; set; }
        }

        public class UserIdentityInfo : Humidifier.Base.BaseSubResource, IHaveFirstName, IHaveLastName, IHaveEmail
        {
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-useridentityinfo.html#cfn-connect-user-useridentityinfo-email
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Email { get; set; }
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-useridentityinfo.html#cfn-connect-user-useridentityinfo-firstname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstName { get; set; }
            /// <summary>
            /// SecondaryEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-useridentityinfo.html#cfn-connect-user-useridentityinfo-secondaryemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecondaryEmail { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-useridentityinfo.html#cfn-connect-user-useridentityinfo-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastName { get; set; }
            /// <summary>
            /// Mobile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-useridentityinfo.html#cfn-connect-user-useridentityinfo-mobile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mobile { get; set; }
        }

        public class UserPhoneConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoAccept
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userphoneconfig.html#cfn-connect-user-userphoneconfig-autoaccept
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoAccept { get; set; }
            /// <summary>
            /// PhoneType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userphoneconfig.html#cfn-connect-user-userphoneconfig-phonetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhoneType { get; set; }
            /// <summary>
            /// PersistentConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userphoneconfig.html#cfn-connect-user-userphoneconfig-persistentconnection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PersistentConnection { get; set; }
            /// <summary>
            /// DeskPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userphoneconfig.html#cfn-connect-user-userphoneconfig-deskphonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeskPhoneNumber { get; set; }
            /// <summary>
            /// AfterContactWorkTimeLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userphoneconfig.html#cfn-connect-user-userphoneconfig-aftercontactworktimelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AfterContactWorkTimeLimit { get; set; }
        }

        public class UserProficiency : Humidifier.Base.BaseSubResource, IHaveAttributeName, IHaveLevel, IHaveAttributeValue
        {
            /// <summary>
            /// AttributeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userproficiency.html#cfn-connect-user-userproficiency-attributevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeValue { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userproficiency.html#cfn-connect-user-userproficiency-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-userproficiency.html#cfn-connect-user-userproficiency-level
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Level { get; set; }
        }

        public class VoiceEnhancementConfig : Humidifier.Base.BaseSubResource, IHaveChannel
        {
            /// <summary>
            /// VoiceEnhancementMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-voiceenhancementconfig.html#cfn-connect-user-voiceenhancementconfig-voiceenhancementmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VoiceEnhancementMode { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-user-voiceenhancementconfig.html#cfn-connect-user-voiceenhancementconfig-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
        }
    }
}