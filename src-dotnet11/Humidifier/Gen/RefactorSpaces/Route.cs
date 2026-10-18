namespace Humidifier.RefactorSpaces
{
    using global::System.Collections.Generic;
    using RouteTypes;

    public class Route : Humidifier.Base.BaseResource, IHaveTags, IHaveRefactorSpacesRouteTypesUriPathRouteInputUriPathRoute, IHaveEnvironmentIdentifier, IHaveRouteType, IHaveRefactorSpacesRouteTypesDefaultRouteInputDefaultRoute, IHaveServiceIdentifier, IHaveApplicationIdentifier
    {
        public class Attributes
        {
            public static string RouteIdentifier =  "RouteIdentifier" ;
            public static string Arn =  "Arn" ;
            public static string PathResourceToId =  "PathResourceToId" ;
        }

        public override string AWSTypeName { get => AWS.RefactorSpaces.Route; }
        /// <summary>
        /// UriPathRoute
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-uripathroute
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UriPathRouteInput
        /// </summary>
        public Union<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput, BaseFunction>? UriPathRoute { get; set; }

        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }

        /// <summary>
        /// RouteType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-routetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RouteType { get; set; }
        /// <summary>
        /// DefaultRoute
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-defaultroute
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultRouteInput
        /// </summary>
        public Union<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput, BaseFunction>? DefaultRoute { get; set; }

        /// <summary>
        /// ServiceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-serviceidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceIdentifier { get; set; }

        /// <summary>
        /// ApplicationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-applicationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-route.html#cfn-refactorspaces-route-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RouteTypes
    {
        public class DefaultRouteInput : Humidifier.Base.BaseSubResource, IHaveActivationState
        {
            /// <summary>
            /// ActivationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-route-defaultrouteinput.html#cfn-refactorspaces-route-defaultrouteinput-activationstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActivationState { get; set; }
        }

        public class UriPathRouteInput : Humidifier.Base.BaseSubResource, IHaveSourcePath, IHaveAppendSourcePath_Boolean, IHaveActivationState, IHaveStringListOfMethods, IHaveIncludeChildPaths_Boolean
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-route-uripathrouteinput.html#cfn-refactorspaces-route-uripathrouteinput-sourcepath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePath { get; set; }
            /// <summary>
            /// AppendSourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-route-uripathrouteinput.html#cfn-refactorspaces-route-uripathrouteinput-appendsourcepath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AppendSourcePath { get; set; }
            /// <summary>
            /// ActivationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-route-uripathrouteinput.html#cfn-refactorspaces-route-uripathrouteinput-activationstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActivationState { get; set; }
            /// <summary>
            /// Methods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-route-uripathrouteinput.html#cfn-refactorspaces-route-uripathrouteinput-methods
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Methods { get; set; }
            /// <summary>
            /// IncludeChildPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-route-uripathrouteinput.html#cfn-refactorspaces-route-uripathrouteinput-includechildpaths
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildPaths { get; set; }
        }
    }
}