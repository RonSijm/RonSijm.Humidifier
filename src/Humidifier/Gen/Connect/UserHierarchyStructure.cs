namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using UserHierarchyStructureTypes;

    public class UserHierarchyStructure : Humidifier.Base.BaseResource, IHaveInstanceArn
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
        public Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure UserHierarchyStructure_ { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-userhierarchystructure.html#cfn-connect-userhierarchystructure-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
    }

    namespace UserHierarchyStructureTypes
    {
        public class LevelFive : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfive.html#cfn-connect-userhierarchystructure-levelfive-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfive.html#cfn-connect-userhierarchystructure-levelfive-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfive.html#cfn-connect-userhierarchystructure-levelfive-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LevelFour : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfour.html#cfn-connect-userhierarchystructure-levelfour-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfour.html#cfn-connect-userhierarchystructure-levelfour-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelfour.html#cfn-connect-userhierarchystructure-levelfour-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LevelOne : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelone.html#cfn-connect-userhierarchystructure-levelone-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelone.html#cfn-connect-userhierarchystructure-levelone-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelone.html#cfn-connect-userhierarchystructure-levelone-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LevelThree : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelthree.html#cfn-connect-userhierarchystructure-levelthree-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelthree.html#cfn-connect-userhierarchystructure-levelthree-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-levelthree.html#cfn-connect-userhierarchystructure-levelthree-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LevelTwo : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// HierarchyLevelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-leveltwo.html#cfn-connect-userhierarchystructure-leveltwo-hierarchylevelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelId { get; set; }
            /// <summary>
            /// HierarchyLevelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-leveltwo.html#cfn-connect-userhierarchystructure-leveltwo-hierarchylevelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyLevelArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-leveltwo.html#cfn-connect-userhierarchystructure-leveltwo-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UserHierarchyStructure : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LevelThree
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelthree
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelThree
            /// </summary>
            public Humidifier.Connect.UserHierarchyStructureTypes.LevelThree LevelThree { get; set; }
            /// <summary>
            /// LevelTwo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-leveltwo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelTwo
            /// </summary>
            public Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo LevelTwo { get; set; }
            /// <summary>
            /// LevelFive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelfive
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelFive
            /// </summary>
            public Humidifier.Connect.UserHierarchyStructureTypes.LevelFive LevelFive { get; set; }
            /// <summary>
            /// LevelFour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelfour
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelFour
            /// </summary>
            public Humidifier.Connect.UserHierarchyStructureTypes.LevelFour LevelFour { get; set; }
            /// <summary>
            /// LevelOne
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-userhierarchystructure-userhierarchystructure.html#cfn-connect-userhierarchystructure-userhierarchystructure-levelone
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LevelOne
            /// </summary>
            public Humidifier.Connect.UserHierarchyStructureTypes.LevelOne LevelOne { get; set; }
        }
    }
}