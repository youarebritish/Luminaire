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
            
			
			
			return fieldProperties;
        }

		
    }
}