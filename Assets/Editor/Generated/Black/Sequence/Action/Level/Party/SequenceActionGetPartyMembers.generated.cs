using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Party
{
    public partial class SequenceActionGetPartyMembers : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorNoctisPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorGladiolusPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorPromptoPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIgnisPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorGuestPin_;
		public bool isExcludingUCPC_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetPartyMembers();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Party.SequenceActionGetPartyMembers", 0, Black.Sequence.Action.Level.Party.SequenceActionGetPartyMembers.ObjectType, null, properties, 0, 712);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Party.SequenceActionGetPartyMembers", base.GetFieldProperties(), -1432185307, -1701074724);
            return fieldProperties;
        }

		
    }
}