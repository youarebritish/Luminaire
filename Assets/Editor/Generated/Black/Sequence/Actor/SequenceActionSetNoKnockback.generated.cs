using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionSetNoKnockback : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outputOPin_;
		public bool bDisableKnockback_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNoKnockback();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionSetNoKnockback", 0, Black.Sequence.Actor.SequenceActionSetNoKnockback.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionSetNoKnockback", base.GetFieldProperties(), -1141603334, 1667964622);
            return fieldProperties;
        }

		
    }
}