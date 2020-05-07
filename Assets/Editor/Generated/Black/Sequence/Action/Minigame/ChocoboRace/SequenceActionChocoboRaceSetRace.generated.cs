using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.ChocoboRace
{
    public partial class SequenceActionChocoboRaceSetRace : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aroundStartPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin goalPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin stopPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roundNum_;
		public int distanceType_;
		public int weatherType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboRaceSetRace();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceSetRace", 0, Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceSetRace.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceSetRace", base.GetFieldProperties(), -2096559452, 153419927);
            
			
			
			return fieldProperties;
        }

		
    }
}