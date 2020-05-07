using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetBattleArea : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveTobattleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnedList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveToSpawnedList_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isPlayerBattleAreaIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battleAreaOutActorListPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin movedToBattleAreaOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public bool isTeritoryOutTimerDeath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetBattleArea", 0, Black.Sequence.Action.Level.SequenceActionSetBattleArea.ObjectType, null, properties, 0, 1328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetBattleArea", base.GetFieldProperties(), 1459537678, -1087664438);
            return fieldProperties;
        }

		
    }
}