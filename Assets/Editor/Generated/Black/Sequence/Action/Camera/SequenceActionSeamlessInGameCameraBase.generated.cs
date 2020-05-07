using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCameraBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		public Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemNew seamlessParameter_;
		public bool isUseEndReserve_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCameraBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase.ObjectType, null, properties, 0, 2400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase", base.GetFieldProperties(), -877317690, 26446116);
            
			
			
			return fieldProperties;
        }

		
    }
}