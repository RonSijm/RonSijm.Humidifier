namespace Humidifier.Logs
{
    using System.Collections.Generic;
    using TransformerTypes;

    public class Transformer : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.Logs.Transformer; }

        /// <summary>
        /// TransformerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-transformer.html#cfn-logs-transformer-transformerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Processor
        /// </summary>
        [Required]
        public List<Humidifier.Logs.TransformerTypes.Processor> TransformerConfig { get; set; }

        /// <summary>
        /// LogGroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-transformer.html#cfn-logs-transformer-loggroupidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LogGroupIdentifier { get; set; }
    }

    namespace TransformerTypes
    {
        public class AddKeyEntry : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// OverwriteIfExists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-addkeyentry.html#cfn-logs-transformer-addkeyentry-overwriteifexists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OverwriteIfExists { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-addkeyentry.html#cfn-logs-transformer-addkeyentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-addkeyentry.html#cfn-logs-transformer-addkeyentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class AddKeys : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-addkeys.html#cfn-logs-transformer-addkeys-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AddKeyEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.AddKeyEntry> Entries { get; set; }
        }

        public class CopyValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-copyvalue.html#cfn-logs-transformer-copyvalue-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CopyValueEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.CopyValueEntry> Entries { get; set; }
        }

        public class CopyValueEntry : Humidifier.Base.BaseSubResource, IHaveSource, IHaveTarget
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-copyvalueentry.html#cfn-logs-transformer-copyvalueentry-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// OverwriteIfExists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-copyvalueentry.html#cfn-logs-transformer-copyvalueentry-overwriteifexists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OverwriteIfExists { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-copyvalueentry.html#cfn-logs-transformer-copyvalueentry-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class Csv : Humidifier.Base.BaseSubResource, IHaveSource, IHaveDelimiter
        {
            /// <summary>
            /// QuoteCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-csv.html#cfn-logs-transformer-csv-quotecharacter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QuoteCharacter { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-csv.html#cfn-logs-transformer-csv-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-csv.html#cfn-logs-transformer-csv-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Columns { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-csv.html#cfn-logs-transformer-csv-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class DateTimeConverter : Humidifier.Base.BaseSubResource, IHaveSource, IHaveTarget
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// MatchPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-matchpatterns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchPatterns { get; set; }
            /// <summary>
            /// SourceTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-sourcetimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceTimezone { get; set; }
            /// <summary>
            /// TargetFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-targetformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetFormat { get; set; }
            /// <summary>
            /// TargetTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-targettimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetTimezone { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-datetimeconverter.html#cfn-logs-transformer-datetimeconverter-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class DeleteKeys : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WithKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-deletekeys.html#cfn-logs-transformer-deletekeys-withkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WithKeys { get; set; }
        }

        public class Grok : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-grok.html#cfn-logs-transformer-grok-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-grok.html#cfn-logs-transformer-grok-match
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Match { get; set; }
        }

        public class ListToMap : Humidifier.Base.BaseSubResource, IHaveKey, IHaveSource, IHaveTarget, IHaveValueKey
        {
            /// <summary>
            /// ValueKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-listtomap.html#cfn-logs-transformer-listtomap-valuekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueKey { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-listtomap.html#cfn-logs-transformer-listtomap-target
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Flatten
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-listtomap.html#cfn-logs-transformer-listtomap-flatten
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Flatten { get; set; }
            /// <summary>
            /// FlattenedElement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-listtomap.html#cfn-logs-transformer-listtomap-flattenedelement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlattenedElement { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-listtomap.html#cfn-logs-transformer-listtomap-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-listtomap.html#cfn-logs-transformer-listtomap-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class LowerCaseString : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WithKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-lowercasestring.html#cfn-logs-transformer-lowercasestring-withkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WithKeys { get; set; }
        }

        public class MoveKeyEntry : Humidifier.Base.BaseSubResource, IHaveSource, IHaveTarget
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-movekeyentry.html#cfn-logs-transformer-movekeyentry-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// OverwriteIfExists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-movekeyentry.html#cfn-logs-transformer-movekeyentry-overwriteifexists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OverwriteIfExists { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-movekeyentry.html#cfn-logs-transformer-movekeyentry-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class MoveKeys : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-movekeys.html#cfn-logs-transformer-movekeys-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MoveKeyEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.MoveKeyEntry> Entries { get; set; }
        }

        public class ParseCloudfront : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsecloudfront.html#cfn-logs-transformer-parsecloudfront-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class ParseJSON : Humidifier.Base.BaseSubResource, IHaveSource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsejson.html#cfn-logs-transformer-parsejson-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsejson.html#cfn-logs-transformer-parsejson-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class ParseKeyValue : Humidifier.Base.BaseSubResource, IHaveSource, IHaveDestination, IHaveKeyPrefix
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// KeyValueDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-keyvaluedelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyValueDelimiter { get; set; }
            /// <summary>
            /// OverwriteIfExists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-overwriteifexists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OverwriteIfExists { get; set; }
            /// <summary>
            /// FieldDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-fielddelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldDelimiter { get; set; }
            /// <summary>
            /// NonMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-nonmatchvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NonMatchValue { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsekeyvalue.html#cfn-logs-transformer-parsekeyvalue-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefix { get; set; }
        }

        public class ParsePostgres : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsepostgres.html#cfn-logs-transformer-parsepostgres-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class ParseRoute53 : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parseroute53.html#cfn-logs-transformer-parseroute53-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class ParseVPC : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsevpc.html#cfn-logs-transformer-parsevpc-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class ParseWAF : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-parsewaf.html#cfn-logs-transformer-parsewaf-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class Processor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParseCloudfront
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parsecloudfront
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParseCloudfront
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParseCloudfront ParseCloudfront { get; set; }
            /// <summary>
            /// LowerCaseString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-lowercasestring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LowerCaseString
            /// </summary>
            public Humidifier.Logs.TransformerTypes.LowerCaseString LowerCaseString { get; set; }
            /// <summary>
            /// UpperCaseString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-uppercasestring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpperCaseString
            /// </summary>
            public Humidifier.Logs.TransformerTypes.UpperCaseString UpperCaseString { get; set; }
            /// <summary>
            /// DeleteKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-deletekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeleteKeys
            /// </summary>
            public Humidifier.Logs.TransformerTypes.DeleteKeys DeleteKeys { get; set; }
            /// <summary>
            /// RenameKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-renamekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RenameKeys
            /// </summary>
            public Humidifier.Logs.TransformerTypes.RenameKeys RenameKeys { get; set; }
            /// <summary>
            /// Grok
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-grok
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Grok
            /// </summary>
            public Humidifier.Logs.TransformerTypes.Grok Grok { get; set; }
            /// <summary>
            /// SplitString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-splitstring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SplitString
            /// </summary>
            public Humidifier.Logs.TransformerTypes.SplitString SplitString { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-csv
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Csv
            /// </summary>
            public Humidifier.Logs.TransformerTypes.Csv Csv { get; set; }
            /// <summary>
            /// AddKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-addkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddKeys
            /// </summary>
            public Humidifier.Logs.TransformerTypes.AddKeys AddKeys { get; set; }
            /// <summary>
            /// SubstituteString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-substitutestring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubstituteString
            /// </summary>
            public Humidifier.Logs.TransformerTypes.SubstituteString SubstituteString { get; set; }
            /// <summary>
            /// ParseKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parsekeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParseKeyValue
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParseKeyValue ParseKeyValue { get; set; }
            /// <summary>
            /// ParseWAF
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parsewaf
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParseWAF
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParseWAF ParseWAF { get; set; }
            /// <summary>
            /// ParseVPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parsevpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParseVPC
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParseVPC ParseVPC { get; set; }
            /// <summary>
            /// ParseRoute53
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parseroute53
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParseRoute53
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParseRoute53 ParseRoute53 { get; set; }
            /// <summary>
            /// TypeConverter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-typeconverter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TypeConverter
            /// </summary>
            public Humidifier.Logs.TransformerTypes.TypeConverter TypeConverter { get; set; }
            /// <summary>
            /// ParseJSON
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parsejson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParseJSON
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParseJSON ParseJSON { get; set; }
            /// <summary>
            /// ParsePostgres
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-parsepostgres
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParsePostgres
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ParsePostgres ParsePostgres { get; set; }
            /// <summary>
            /// CopyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-copyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CopyValue
            /// </summary>
            public Humidifier.Logs.TransformerTypes.CopyValue CopyValue { get; set; }
            /// <summary>
            /// MoveKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-movekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MoveKeys
            /// </summary>
            public Humidifier.Logs.TransformerTypes.MoveKeys MoveKeys { get; set; }
            /// <summary>
            /// DateTimeConverter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-datetimeconverter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeConverter
            /// </summary>
            public Humidifier.Logs.TransformerTypes.DateTimeConverter DateTimeConverter { get; set; }
            /// <summary>
            /// TrimString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-trimstring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrimString
            /// </summary>
            public Humidifier.Logs.TransformerTypes.TrimString TrimString { get; set; }
            /// <summary>
            /// ListToMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-processor.html#cfn-logs-transformer-processor-listtomap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListToMap
            /// </summary>
            public Humidifier.Logs.TransformerTypes.ListToMap ListToMap { get; set; }
        }

        public class RenameKeyEntry : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// OverwriteIfExists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-renamekeyentry.html#cfn-logs-transformer-renamekeyentry-overwriteifexists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OverwriteIfExists { get; set; }
            /// <summary>
            /// RenameTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-renamekeyentry.html#cfn-logs-transformer-renamekeyentry-renameto
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RenameTo { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-renamekeyentry.html#cfn-logs-transformer-renamekeyentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class RenameKeys : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-renamekeys.html#cfn-logs-transformer-renamekeys-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RenameKeyEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.RenameKeyEntry> Entries { get; set; }
        }

        public class SplitString : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-splitstring.html#cfn-logs-transformer-splitstring-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SplitStringEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.SplitStringEntry> Entries { get; set; }
        }

        public class SplitStringEntry : Humidifier.Base.BaseSubResource, IHaveSource, IHaveDelimiter
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-splitstringentry.html#cfn-logs-transformer-splitstringentry-delimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-splitstringentry.html#cfn-logs-transformer-splitstringentry-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class SubstituteString : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-substitutestring.html#cfn-logs-transformer-substitutestring-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubstituteStringEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.SubstituteStringEntry> Entries { get; set; }
        }

        public class SubstituteStringEntry : Humidifier.Base.BaseSubResource, IHaveSource, IHaveFrom, IHaveTo
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-substitutestringentry.html#cfn-logs-transformer-substitutestringentry-from
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-substitutestringentry.html#cfn-logs-transformer-substitutestringentry-to
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic To { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-substitutestringentry.html#cfn-logs-transformer-substitutestringentry-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class TrimString : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WithKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-trimstring.html#cfn-logs-transformer-trimstring-withkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WithKeys { get; set; }
        }

        public class TypeConverter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Entries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-typeconverter.html#cfn-logs-transformer-typeconverter-entries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TypeConverterEntry
            /// </summary>
            public List<Humidifier.Logs.TransformerTypes.TypeConverterEntry> Entries { get; set; }
        }

        public class TypeConverterEntry : Humidifier.Base.BaseSubResource, IHaveType, IHaveKey
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-typeconverterentry.html#cfn-logs-transformer-typeconverterentry-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-typeconverterentry.html#cfn-logs-transformer-typeconverterentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class UpperCaseString : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WithKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-transformer-uppercasestring.html#cfn-logs-transformer-uppercasestring-withkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WithKeys { get; set; }
        }
    }
}