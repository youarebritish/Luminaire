using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Monster
{
    public partial class SequenceActionAIMonPartsHPRecover : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isDestructed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin partsFixidPinValue_;
		public uint partsFixId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin hpRatePinValue_;
		public float hpRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIMonPartsHPRecover();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Monster.SequenceActionAIMonPartsHPRecover", 0, Black.Sequence.Actor.AI.Monster.SequenceActionAIMonPartsHPRecover.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Monster.SequenceActionAIMonPartsHPRecover", base.GetFieldProperties(), -778891121, 1602790714);
            
			
			
			return fieldProperties;
        }

		
    }
}