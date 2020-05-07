using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetBattleAreaSpawnList : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin spawnActorListPin_;
		public int prefixType_;
		public uint teritoryFixId_;
		public uint teritoryFixId_sub_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin createdList_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedList_;
		public bool isUseGroupTeritoryFixid_;
		public bool isUpdate_;
		public bool isCheckBattleAreaInPlayer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueBattleAreaFixid_;
		public bool bExcludeDead_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetBattleAreaSpawnList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetBattleAreaSpawnList", 0, Black.Sequence.Action.Level.SequenceActionGetBattleAreaSpawnList.ObjectType, null, properties, 0, 920);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetBattleAreaSpawnList", base.GetFieldProperties(), 1135030895, 615927087);
            return fieldProperties;
        }

		
    }
}