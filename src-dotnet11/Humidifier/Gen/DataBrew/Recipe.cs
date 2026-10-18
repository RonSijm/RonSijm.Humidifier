namespace Humidifier.DataBrew
{
    using global::System.Collections.Generic;
    using RecipeTypes;

    public class Recipe : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfDataBrewRecipeTypesRecipeStepSteps, IHaveDescription, IHaveName
    {
        public override string AWSTypeName { get => AWS.DataBrew.Recipe; }

        /// <summary>
        /// Steps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-steps
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RecipeStep
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DataBrew.RecipeTypes.RecipeStep>, IReadOnlyList<Union<Humidifier.DataBrew.RecipeTypes.RecipeStep, BaseFunction>>, BaseFunction>? Steps { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RecipeTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveDataBrewRecipeTypesRecipeParametersParameters, IHaveOperation
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-action.html#cfn-databrew-recipe-action-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecipeParameters
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.RecipeParameters, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Operation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-action.html#cfn-databrew-recipe-action-operation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operation { get; set; }
        }

        public class ConditionExpression : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveValue, IHaveTargetColumn
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html#cfn-databrew-recipe-conditionexpression-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html#cfn-databrew-recipe-conditionexpression-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// TargetColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html#cfn-databrew-recipe-conditionexpression-targetcolumn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetColumn { get; set; }
        }

        public class DataCatalogInputDefinition : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveTableName, IHaveDataBrewRecipeTypesS3LocationTempDirectory, IHaveCatalogId
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-datacataloginputdefinition.html#cfn-databrew-recipe-datacataloginputdefinition-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-datacataloginputdefinition.html#cfn-databrew-recipe-datacataloginputdefinition-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-datacataloginputdefinition.html#cfn-databrew-recipe-datacataloginputdefinition-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.S3Location, BaseFunction>? TempDirectory { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-datacataloginputdefinition.html#cfn-databrew-recipe-datacataloginputdefinition-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class Input : Humidifier.Base.BaseSubResource, IHaveDataBrewRecipeTypesS3LocationS3InputDefinition, IHaveDataBrewRecipeTypesDataCatalogInputDefinitionDataCatalogInputDefinition
        {
            /// <summary>
            /// S3InputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-input.html#cfn-databrew-recipe-input-s3inputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.S3Location, BaseFunction>? S3InputDefinition { get; set; }
            /// <summary>
            /// DataCatalogInputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-input.html#cfn-databrew-recipe-input-datacataloginputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataCatalogInputDefinition
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition, BaseFunction>? DataCatalogInputDefinition { get; set; }
        }

        public class RecipeParameters : Humidifier.Base.BaseSubResource, IHaveIgnoreCase, IHavePatternOptions, IHaveCount, IHaveOrderByColumn, IHaveUpperBound, IHaveJoinKeys, IHaveRemoveLeadingAndTrailingPunctuation, IHaveStepIndex, IHaveGroupByAggFunctionOptions, IHavePosition, IHaveStopWordsMode, IHaveSourceColumn, IHaveCustomCharacters, IHaveTimeZone, IHaveRemoveLeadingAndTrailingQuotes, IHaveSourceColumn2, IHaveCollapseConsecutiveWhitespace, IHaveNumRowsAfter, IHaveRemoveLetters, IHaveSourceColumn1, IHaveUseNewDataFrame, IHaveInterval, IHaveLowerBound, IHaveTokenizerPattern, IHaveLeftColumns, IHaveCharsToRemove, IHaveValue1, IHaveDeleteOtherRows, IHaveValue2, IHaveCategoryMap, IHaveStartPattern, IHaveStartPosition, IHaveIntegerListOfSheetIndexes, IHaveTargetIndex, IHaveRemoveSourceColumn, IHaveDateTimeParameters, IHaveEndValue, IHaveRemoveCustomCharacters, IHaveEndPosition, IHavePattern, IHaveDelimiter, IHaveRemoveSpecialCharacters, IHaveRemoveAllQuotes, IHaveEndPattern, IHaveStartColumnIndex, IHaveModeType, IHaveListOfDataBrewRecipeTypesSecondaryInputSecondaryInputs, IHaveSampleType, IHaveDateTimeFormat, IHaveOther, IHaveCaseStatement, IHaveFalseString, IHaveRemoveAllPunctuation, IHaveCustomStopWords, IHaveMapType, IHaveColumnRange, IHaveCustomValue, IHaveDataBrewRecipeTypesInputInput, IHaveStepCount, IHaveTargetDateFormat, IHaveSecondInput, IHaveGroupByColumns, IHaveNumRowsBefore, IHaveIsText, IHaveTargetColumn, IHaveRemoveNumbers, IHavePeriod, IHaveNumRows, IHaveRightColumns, IHaveStemmingMode, IHaveUnits, IHaveSampleSize, IHaveIncludeInSplit, IHaveAggregateFunction, IHaveValue, IHaveExponent, IHaveStartValue, IHavePatternOption2, IHaveRemoveCustomValue, IHavePatternOption1, IHaveMultiLine_Boolean, IHaveTrueString, IHaveRemoveLeadingAndTrailingWhitespace, IHaveHiddenColumns, IHaveRemoveAllWhitespace, IHaveViewFrame, IHaveColumnDataType, IHaveJoinType, IHaveBase, IHaveValueColumn, IHaveDatasetsColumns, IHaveUdfLang, IHaveTargetColumnNames, IHaveDateAddValue, IHaveExpandContractions, IHaveUnpivotColumn, IHaveStrategy, IHaveStringListOfSheetNames, IHaveLimit, IHaveOrderByColumns, IHaveSourceColumns
        {
            /// <summary>
            /// IgnoreCase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-ignorecase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IgnoreCase { get; set; }
            /// <summary>
            /// PatternOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-patternoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternOptions { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Count { get; set; }
            /// <summary>
            /// OrderByColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-orderbycolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrderByColumn { get; set; }
            /// <summary>
            /// UpperBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-upperbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpperBound { get; set; }
            /// <summary>
            /// JoinKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-joinkeys
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JoinKeys { get; set; }
            /// <summary>
            /// RemoveLeadingAndTrailingPunctuation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeleadingandtrailingpunctuation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveLeadingAndTrailingPunctuation { get; set; }
            /// <summary>
            /// StepIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-stepindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepIndex { get; set; }
            /// <summary>
            /// GroupByAggFunctionOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-groupbyaggfunctionoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupByAggFunctionOptions { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Position { get; set; }
            /// <summary>
            /// StopWordsMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-stopwordsmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StopWordsMode { get; set; }
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sourcecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumn { get; set; }
            /// <summary>
            /// CustomCharacters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-customcharacters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomCharacters { get; set; }
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeZone { get; set; }
            /// <summary>
            /// RemoveLeadingAndTrailingQuotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeleadingandtrailingquotes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveLeadingAndTrailingQuotes { get; set; }
            /// <summary>
            /// SourceColumn2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sourcecolumn2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumn2 { get; set; }
            /// <summary>
            /// CollapseConsecutiveWhitespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-collapseconsecutivewhitespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollapseConsecutiveWhitespace { get; set; }
            /// <summary>
            /// NumRowsAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-numrowsafter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NumRowsAfter { get; set; }
            /// <summary>
            /// RemoveLetters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeletters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveLetters { get; set; }
            /// <summary>
            /// SourceColumn1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sourcecolumn1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumn1 { get; set; }
            /// <summary>
            /// UseNewDataFrame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-usenewdataframe
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseNewDataFrame { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// LowerBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-lowerbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LowerBound { get; set; }
            /// <summary>
            /// TokenizerPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-tokenizerpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenizerPattern { get; set; }
            /// <summary>
            /// LeftColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-leftcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LeftColumns { get; set; }
            /// <summary>
            /// CharsToRemove
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-charstoremove
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CharsToRemove { get; set; }
            /// <summary>
            /// Value1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-value1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value1 { get; set; }
            /// <summary>
            /// DeleteOtherRows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-deleteotherrows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeleteOtherRows { get; set; }
            /// <summary>
            /// Value2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-value2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value2 { get; set; }
            /// <summary>
            /// CategoryMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-categorymap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CategoryMap { get; set; }
            /// <summary>
            /// StartPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-startpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartPattern { get; set; }
            /// <summary>
            /// StartPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-startposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartPosition { get; set; }
            /// <summary>
            /// SheetIndexes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sheetindexes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? SheetIndexes { get; set; }
            /// <summary>
            /// TargetIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-targetindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetIndex { get; set; }
            /// <summary>
            /// RemoveSourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removesourcecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveSourceColumn { get; set; }
            /// <summary>
            /// DateTimeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-datetimeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateTimeParameters { get; set; }
            /// <summary>
            /// EndValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-endvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndValue { get; set; }
            /// <summary>
            /// RemoveCustomCharacters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removecustomcharacters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveCustomCharacters { get; set; }
            /// <summary>
            /// EndPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-endposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndPosition { get; set; }
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Delimiter { get; set; }
            /// <summary>
            /// RemoveSpecialCharacters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removespecialcharacters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveSpecialCharacters { get; set; }
            /// <summary>
            /// RemoveAllQuotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeallquotes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveAllQuotes { get; set; }
            /// <summary>
            /// EndPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-endpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndPattern { get; set; }
            /// <summary>
            /// StartColumnIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-startcolumnindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartColumnIndex { get; set; }
            /// <summary>
            /// ModeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-modetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModeType { get; set; }
            /// <summary>
            /// SecondaryInputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-secondaryinputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SecondaryInput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.RecipeTypes.SecondaryInput>, IReadOnlyList<Union<Humidifier.DataBrew.RecipeTypes.SecondaryInput, BaseFunction>>, BaseFunction>? SecondaryInputs { get; set; }
            /// <summary>
            /// SampleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sampletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SampleType { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateTimeFormat { get; set; }
            /// <summary>
            /// Other
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-other
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Other { get; set; }
            /// <summary>
            /// CaseStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-casestatement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaseStatement { get; set; }
            /// <summary>
            /// FalseString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-falsestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FalseString { get; set; }
            /// <summary>
            /// RemoveAllPunctuation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeallpunctuation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveAllPunctuation { get; set; }
            /// <summary>
            /// CustomStopWords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-customstopwords
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomStopWords { get; set; }
            /// <summary>
            /// MapType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-maptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MapType { get; set; }
            /// <summary>
            /// ColumnRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-columnrange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnRange { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomValue { get; set; }
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-input
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Input
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.Input, BaseFunction>? Input { get; set; }
            /// <summary>
            /// StepCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-stepcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepCount { get; set; }
            /// <summary>
            /// TargetDateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-targetdateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetDateFormat { get; set; }
            /// <summary>
            /// SecondInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-secondinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecondInput { get; set; }
            /// <summary>
            /// GroupByColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-groupbycolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupByColumns { get; set; }
            /// <summary>
            /// NumRowsBefore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-numrowsbefore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NumRowsBefore { get; set; }
            /// <summary>
            /// IsText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-istext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsText { get; set; }
            /// <summary>
            /// TargetColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-targetcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetColumn { get; set; }
            /// <summary>
            /// RemoveNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removenumbers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveNumbers { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Period { get; set; }
            /// <summary>
            /// NumRows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-numrows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NumRows { get; set; }
            /// <summary>
            /// RightColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-rightcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RightColumns { get; set; }
            /// <summary>
            /// StemmingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-stemmingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StemmingMode { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Units { get; set; }
            /// <summary>
            /// SampleSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-samplesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SampleSize { get; set; }
            /// <summary>
            /// IncludeInSplit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-includeinsplit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludeInSplit { get; set; }
            /// <summary>
            /// AggregateFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-aggregatefunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AggregateFunction { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Exponent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-exponent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exponent { get; set; }
            /// <summary>
            /// StartValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-startvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartValue { get; set; }
            /// <summary>
            /// PatternOption2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-patternoption2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternOption2 { get; set; }
            /// <summary>
            /// RemoveCustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removecustomvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveCustomValue { get; set; }
            /// <summary>
            /// PatternOption1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-patternoption1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternOption1 { get; set; }
            /// <summary>
            /// MultiLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-multiline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiLine { get; set; }
            /// <summary>
            /// TrueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-truestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrueString { get; set; }
            /// <summary>
            /// RemoveLeadingAndTrailingWhitespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeleadingandtrailingwhitespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveLeadingAndTrailingWhitespace { get; set; }
            /// <summary>
            /// HiddenColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-hiddencolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HiddenColumns { get; set; }
            /// <summary>
            /// RemoveAllWhitespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-removeallwhitespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoveAllWhitespace { get; set; }
            /// <summary>
            /// ViewFrame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-viewframe
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewFrame { get; set; }
            /// <summary>
            /// ColumnDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-columndatatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnDataType { get; set; }
            /// <summary>
            /// JoinType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-jointype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JoinType { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Base { get; set; }
            /// <summary>
            /// ValueColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-valuecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueColumn { get; set; }
            /// <summary>
            /// DatasetsColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-datasetscolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetsColumns { get; set; }
            /// <summary>
            /// UdfLang
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-udflang
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UdfLang { get; set; }
            /// <summary>
            /// TargetColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-targetcolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetColumnNames { get; set; }
            /// <summary>
            /// DateAddValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-dateaddvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateAddValue { get; set; }
            /// <summary>
            /// ExpandContractions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-expandcontractions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpandContractions { get; set; }
            /// <summary>
            /// UnpivotColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-unpivotcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnpivotColumn { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-strategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
            /// <summary>
            /// SheetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sheetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SheetNames { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Limit { get; set; }
            /// <summary>
            /// OrderByColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-orderbycolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrderByColumns { get; set; }
            /// <summary>
            /// SourceColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html#cfn-databrew-recipe-recipeparameters-sourcecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumns { get; set; }
        }

        public class RecipeStep : Humidifier.Base.BaseSubResource, IHaveDataBrewRecipeTypesActionAction, IHaveListOfDataBrewRecipeTypesConditionExpressionConditionExpressions
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipestep.html#cfn-databrew-recipe-recipestep-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Action
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.Action, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ConditionExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipestep.html#cfn-databrew-recipe-recipestep-conditionexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConditionExpression
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.RecipeTypes.ConditionExpression>, IReadOnlyList<Union<Humidifier.DataBrew.RecipeTypes.ConditionExpression, BaseFunction>>, BaseFunction>? ConditionExpressions { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-s3location.html#cfn-databrew-recipe-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-s3location.html#cfn-databrew-recipe-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SecondaryInput : Humidifier.Base.BaseSubResource, IHaveDataBrewRecipeTypesS3LocationS3InputDefinition, IHaveDataBrewRecipeTypesDataCatalogInputDefinitionDataCatalogInputDefinition
        {
            /// <summary>
            /// S3InputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-secondaryinput.html#cfn-databrew-recipe-secondaryinput-s3inputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.S3Location, BaseFunction>? S3InputDefinition { get; set; }
            /// <summary>
            /// DataCatalogInputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-secondaryinput.html#cfn-databrew-recipe-secondaryinput-datacataloginputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataCatalogInputDefinition
            /// </summary>
            public Union<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition, BaseFunction>? DataCatalogInputDefinition { get; set; }
        }
    }
}