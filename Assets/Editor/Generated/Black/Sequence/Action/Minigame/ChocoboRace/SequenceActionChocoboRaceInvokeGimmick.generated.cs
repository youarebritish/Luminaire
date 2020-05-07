using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.ChocoboRace
{
    public partial class SequenceActionChocoboRaceInvokeGimmick : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roundNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin index_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin invokeCondition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin invoke_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboRaceInvokeGimmick();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceInvokeGimmick", 0, Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceInvokeGimmick.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.ChocoboRace.SequenceActionChocoboRaceInvokeGimmick", base.GetFieldProperties(), -154778989, -982156429);
            
			
			
			return fieldProperties;
        }

		
    }
}