using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikTimeControl : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float timeStepScale_;
		public bool stableMode_;
		public int subStep_;
		public int solverIter_;
		public int linkIter_;
		public int collIter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikTimeControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikTimeControl", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikTimeControl.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikTimeControl", base.GetFieldProperties(), 624686603, -1360472967);
            return fieldProperties;
        }

		
    }
}