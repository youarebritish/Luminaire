using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.ChocoboRace
{
    public partial class SequenceActionChocoboRaceBetUI : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin close_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin openLevel_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboRaceBetUI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceBetUI", 0, Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceBetUI.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceBetUI", base.GetFieldProperties(), 1287364921, -1378998530);
            return fieldProperties;
        }

		
    }
}