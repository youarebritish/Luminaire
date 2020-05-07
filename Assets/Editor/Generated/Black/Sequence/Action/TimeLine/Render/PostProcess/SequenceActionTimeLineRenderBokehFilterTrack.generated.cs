using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineRenderBokehFilterTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUseCurrentCamera4FocalPlane_;
		public bool foculLengthFlag_;
		public bool fNumberFlag_;
		public bool focalPlaneFlag_;
		public bool focalPlaneRadiusFlag_;
		public bool maxCoCSizeNearFlag_;
		public bool maxCoCSizeFarFlag_;
		public bool initialEnergyScaleFlag_;
		public bool switchOverFlag_;
		public Black.System.TimeLine.TrackItem.BokehFilterTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderBokehFilterTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineRenderBokehFilterTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineRenderBokehFilterTrack.ObjectType, null, properties, 0, 512);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineRenderBokehFilterTrack", base.GetFieldProperties(), 1099745544, -1767578279);
            
			fieldProperties.AddProperty(new Property("isUseCurrentCamera4FocalPlane_", 2667300484, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("foculLengthFlag_", 1387997117, "bool", 321, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("fNumberFlag_", 1012473331, "bool", 322, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("focalPlaneFlag_", 2953050983, "bool", 323, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("focalPlaneRadiusFlag_", 3263124997, "bool", 324, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxCoCSizeNearFlag_", 2369657758, "bool", 325, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxCoCSizeFarFlag_", 1023162465, "bool", 326, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialEnergyScaleFlag_", 1284356426, "bool", 327, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("switchOverFlag_", 2875457958, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "Black.System.TimeLine.TrackItem.BokehFilterTrackItem", 336, 144, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}