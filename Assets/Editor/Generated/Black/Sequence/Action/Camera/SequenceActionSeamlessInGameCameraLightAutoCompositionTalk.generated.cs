using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCameraLightAutoCompositionTalk : Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lastKeepPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPlusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relativeTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogTargetPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCameraLightAutoCompositionTalk();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightAutoCompositionTalk", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightAutoCompositionTalk.ObjectType, null, properties, 0, 2848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightAutoCompositionTalk", base.GetFieldProperties(), -1149227208, -2017374137);
            
			
			
			return fieldProperties;
        }

		
    }
}