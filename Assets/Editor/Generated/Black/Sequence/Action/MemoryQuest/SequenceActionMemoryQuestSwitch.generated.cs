using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.MemoryQuest
{
    public partial class SequenceActionMemoryQuestSwitch : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest_;
		public int argumentNum_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest8_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest7_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest6_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest5_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin quest1_;
		public uint memoryQuestParamId1_;
		public uint memoryQuestParamId2_;
		public uint memoryQuestParamId3_;
		public uint memoryQuestParamId4_;
		public uint memoryQuestParamId5_;
		public uint memoryQuestParamId6_;
		public uint memoryQuestParamId7_;
		public uint memoryQuestParamId8_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMemoryQuestSwitch();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.MemoryQuest.SequenceActionMemoryQuestSwitch", 0, Black.Sequence.Action.MemoryQuest.SequenceActionMemoryQuestSwitch.ObjectType, null, properties, 0, 1304);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.MemoryQuest.SequenceActionMemoryQuestSwitch", base.GetFieldProperties(), 268104042, 967915255);
            return fieldProperties;
        }

		
    }
}