using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorAddBuff : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin release_;
		public int playerBankNumber_;
		public int buff_;
		public int buffLevel_;
		public int buffTime_;
		public bool buffClear_;
		public bool drawMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddBuff();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorAddBuff", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorAddBuff.ObjectType, null, properties, 0, 696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorAddBuff", base.GetFieldProperties(), -1695372550, 1791307310);
            return fieldProperties;
        }

		
    }
}