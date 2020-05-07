using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugSetActorStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inSpeed_;
		public int type_;
		public bool flag_;
		public float speed_;
		public bool activeMaskFlag_;
		public bool noctis_;
		public bool gladiolus_;
		public bool ignis_;
		public bool prompto_;
		public bool guest_;
		public bool enemies_;
		public bool party_;
		public bool partyWithoutPlayer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugSetActorStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugSetActorStatus", 0, Black.Sequence.Action.Debug.SequenceActionDebugSetActorStatus.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugSetActorStatus", base.GetFieldProperties(), 931427685, -1978362502);
            
			
			
			return fieldProperties;
        }

		
    }
}