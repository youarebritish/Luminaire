using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.ChocoboRace
{
    public partial class SequenceActionChocoboRaceTipster : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin openLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin firstID_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin secondID_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin thirdID_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin strOutput_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboRaceTipster();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceTipster", 0, Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceTipster.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceTipster", base.GetFieldProperties(), -1140543375, 1230194946);
            return fieldProperties;
        }

		
    }
}