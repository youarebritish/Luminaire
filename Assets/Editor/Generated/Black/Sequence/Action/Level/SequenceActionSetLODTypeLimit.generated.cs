using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetLODTypeLimit : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int actorLODLvl0_;
		public int actorLODLvl1_;
		public int actorLODLvl2_;
		public int actorLODLvl3_;
		public int lodType_;
		public bool resetDefault_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLODTypeLimit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetLODTypeLimit", 0, Black.Sequence.Action.Level.SequenceActionSetLODTypeLimit.ObjectType, null, properties, 0, 392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetLODTypeLimit", base.GetFieldProperties(), 486023021, 510484174);
            return fieldProperties;
        }

		
    }
}