using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Base
{
    public partial class SequenceActionInterpolationBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timerPin_;
		public int blendModeType_;
		public float timer_;
		public float speed_;
		public float BlendExp;
		public bool bLockOutgoing;
		public SQEX.Ebony.Framework.TimeControl.AnchorPointList anchorPointList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionInterpolationBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Base.SequenceActionInterpolationBase", 0, Black.Sequence.Action.Base.SequenceActionInterpolationBase.ObjectType, null, properties, 0, 312);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Base.SequenceActionInterpolationBase", base.GetFieldProperties(), -948426119, -1510371568);
            return fieldProperties;
        }

		
    }
}