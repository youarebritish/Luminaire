using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionSeamlessInGameTransformActorFromVector : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromBasePositionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin toActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin toMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin toOffsetPin_;
		public bool isUpdateEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameTransformActorFromVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionSeamlessInGameTransformActorFromVector", 0, Black.Sequence.Action.Angle.SequenceActionSeamlessInGameTransformActorFromVector.ObjectType, null, properties, 0, 2144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionSeamlessInGameTransformActorFromVector", base.GetFieldProperties(), 1019405556, 2045158666);
            
			
			
			return fieldProperties;
        }

		
    }
}