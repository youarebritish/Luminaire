using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionCameraPresetCalcLogic : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor1InPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor2InPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vector1InPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin float1InPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin int1InPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin commandSetInPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin float1OutPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraPresetCalcLogic();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionCameraPresetCalcLogic", 0, Black.Sequence.SequenceActionCameraPresetCalcLogic.ObjectType, null, properties, 0, 1232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionCameraPresetCalcLogic", base.GetFieldProperties(), -2114234167, 1900937687);
            
			
			
			return fieldProperties;
        }

		
    }
}