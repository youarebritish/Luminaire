using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyTeamResultLotClear : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint seedId_;
		public bool isNotClearLotDay_;
		public bool isNotClearLotNight_;
		public bool isNotClearLotMorning_;
		public bool isNotTeamsLot_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyTeamResultLotClear();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyTeamResultLotClear", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyTeamResultLotClear.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyTeamResultLotClear", base.GetFieldProperties(), -1397685373, -1109990185);
            return fieldProperties;
        }

		
    }
}