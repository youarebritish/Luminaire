using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.ChocoboRace
{
    public partial class SequenceActionChocoboRaceSetActor : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo5_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboRaceSetActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceSetActor", 0, Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceSetActor.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceSetActor", base.GetFieldProperties(), -424294840, 227692008);
            return fieldProperties;
        }

		
    }
}