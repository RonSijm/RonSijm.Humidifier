namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using UserHierarchyStructureTypes;

    public class UserHierarchyStructure : Humidifier.Base.BaseResource, IHaveConnectUserHierarchyStructureTypesUserHierarchyStructureUserHierarchyStructure_, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string UserHierarchyStructureArn =  "UserHierarchyStructureArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.UserHierarchyStructure; }
        /// <summary>
        /// UserHierarchyStructure_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserHierarchyStructure
        /// </summary>
        public Union<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure, BaseFunction>? UserHierarchyStructure_ { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-userhierarchystructure.html#cfn-connect-userhierarchystructure-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
    }

    namespace UserHierarchyStructureTypes
    {
        public class LevelFive : Humidifier.Base.BaseSubResource, IHaveHierarchyLevelId, IHaveHierarchyLevelArn, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfive.html#cfn-connect-userhierarchystructure-levelfive-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfive.html#cfn-connect-userhierarchystructure-levelfive-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfive.html#cfn-connect-userhierarchystructure-levelfive-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LevelFour : Humidifier.Base.BaseSubResource, IHaveHierarchyLevelId, IHaveHierarchyLevelArn, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfour.html#cfn-connect-userhierarchystructure-levelfour-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfour.html#cfn-connect-userhierarchystructure-levelfour-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfour.html#cfn-connect-userhierarchystructure-levelfour-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LevelOne : Humidifier.Base.BaseSubResource, IHaveHierarchyLevelId, IHaveHierarchyLevelArn, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelone.html#cfn-connect-userhierarchystructure-levelone-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelone.html#cfn-connect-userhierarchystructure-levelone-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelone.html#cfn-connect-userhierarchystructure-levelone-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LevelThree : Humidifier.Base.BaseSubResource, IHaveHierarchyLevelId, IHaveHierarchyLevelArn, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelthree.html#cfn-connect-userhierarchystructure-levelthree-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelthree.html#cfn-connect-userhierarchystructure-levelthree-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelthree.html#cfn-connect-userhierarchystructure-levelthree-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LevelTwo : Humidifier.Base.BaseSubResource, IHaveHierarchyLevelId, IHaveHierarchyLevelArn, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-leveltwo.html#cfn-connect-userhierarchystructure-leveltwo-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-leveltwo.html#cfn-connect-userhierarchystructure-leveltwo-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-leveltwo.html#cfn-connect-userhierarchystructure-leveltwo-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UserHierarchyStructure : Humidifier.Base.BaseSubResource, IHaveConnectUserHierarchyStructureTypesLevelThreeLevelThree, IHaveConnectUserHierarchyStructureTypesLevelTwoLevelTwo, IHaveConnectUserHierarchyStructureTypesLevelFiveLevelFive, IHaveConnectUserHierarchyStructureTypesLevelFourLevelFour, IHaveConnectUserHierarchyStructureTypesLevelOneLevelOne
        {
            /// <summary>
            /// LevelThree
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelthree
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelThree
            /// </summary>
            public Union<Humidifier.Connect.UserHierarchyStructureTypes.LevelThree, BaseFunction>? LevelThree { get; set; }
            /// <summary>
            /// LevelTwo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-leveltwo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelTwo
            /// </summary>
            public Union<Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo, BaseFunction>? LevelTwo { get; set; }
            /// <summary>
            /// LevelFive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelfive
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelFive
            /// </summary>
            public Union<Humidifier.Connect.UserHierarchyStructureTypes.LevelFive, BaseFunction>? LevelFive { get; set; }
            /// <summary>
            /// LevelFour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelfour
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelFour
            /// </summary>
            public Union<Humidifier.Connect.UserHierarchyStructureTypes.LevelFour, BaseFunction>? LevelFour { get; set; }
            /// <summary>
            /// LevelOne
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelone
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelOne
            /// </summary>
            public Union<Humidifier.Connect.UserHierarchyStructureTypes.LevelOne, BaseFunction>? LevelOne { get; set; }
        }
    }
}