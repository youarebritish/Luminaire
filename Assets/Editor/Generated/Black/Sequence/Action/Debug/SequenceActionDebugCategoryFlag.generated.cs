using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugCategoryFlag : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succsessed_;
		public bool isConditionMission_;
		public bool isConditionQuest_;
		public bool isConditionDunsion_;
		public bool isConditionCombat_;
		public bool isConditionEvent_;
		public bool isConditionEnvironment_;
		public bool isConditionFreindAI_;
		public bool isConditionRpgSystem_;
		public bool isConditionTrainRpg_;
		public bool isConditionWorldMapSpecial_;
		public bool isConditionWorldMapNormal_;
		public bool isConditionSound_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugCategoryFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugCategoryFlag", 0, Black.Sequence.Action.Debug.SequenceActionDebugCategoryFlag.ObjectType, null, properties, 0, 280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugCategoryFlag", base.GetFieldProperties(), 1155028660, -1359049020);
            return fieldProperties;
        }

		
    }
}