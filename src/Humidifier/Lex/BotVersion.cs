namespace Humidifier.Lex
{
    using System.Collections.Generic;
    using BotVersionTypes;

    public class BotVersion : Humidifier.Resource, IHaveDescription
    {
        public class Attributes
        {
            public static string BotVersion =  "BotVersion" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lex::BotVersion";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botversion.html#cfn-lex-botversion-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// BotId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botversion.html#cfn-lex-botversion-botid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BotId { get; set; }
        /// <summary>
        /// BotVersionLocaleSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botversion.html#cfn-lex-botversion-botversionlocalespecification
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BotVersionLocaleSpecification
        /// </summary>
        public List<BotVersionLocaleSpecification> BotVersionLocaleSpecification { get; set; }
    }

    namespace BotVersionTypes
    {
        public class BotVersionLocaleDetails
        {
            /// <summary>
            /// SourceBotVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botversion-botversionlocaledetails.html#cfn-lex-botversion-botversionlocaledetails-sourcebotversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceBotVersion { get; set; }
        }

        public class BotVersionLocaleSpecification
        {
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botversion-botversionlocalespecification.html#cfn-lex-botversion-botversionlocalespecification-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleId { get; set; }
            /// <summary>
            /// BotVersionLocaleDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botversion-botversionlocalespecification.html#cfn-lex-botversion-botversionlocalespecification-botversionlocaledetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BotVersionLocaleDetails
            /// </summary>
            public BotVersionLocaleDetails BotVersionLocaleDetails { get; set; }
        }
    }
}