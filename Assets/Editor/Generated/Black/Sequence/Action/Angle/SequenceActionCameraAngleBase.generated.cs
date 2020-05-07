using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cache2InputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cacheInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cache2RotOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cacheRotOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cache2PosOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cachePosOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cache2OutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cacheOutputPin_;
		public bool isCachePositionAndRotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleBase", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleBase.ObjectType, null, properties, 0, 1176);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleBase", base.GetFieldProperties(), 130570056, 622251262);
            
			
			
			return fieldProperties;
        }

		
    }
}