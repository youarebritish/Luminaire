using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorAddExp : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin Source_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin exp_;
		public int addExp_;
		public bool drawMenu_;
		public bool randomPlayer_;
		public bool partyPlayer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddExp();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorAddExp", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorAddExp.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorAddExp", base.GetFieldProperties(), 2120301106, 1012915136);
            return fieldProperties;
        }

		
    }
}