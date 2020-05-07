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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest_", 3585505094, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("argumentNum_", 1806116595, "int", 464, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest8_", 2253829504, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest7_", 3328435763, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest6_", 2254815242, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest5_", 2254373957, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest4_", 3328288668, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest3_", 2255359695, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest2_", 2255506790, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quest1_", 3328729953, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1144, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId1_", 3373942424, "SQEX.Ebony.Std.Fixid", 1240, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId2_", 152889839, "SQEX.Ebony.Std.Fixid", 1244, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId3_", 153036934, "SQEX.Ebony.Std.Fixid", 1248, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId4_", 151904101, "SQEX.Ebony.Std.Fixid", 1252, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId5_", 3373354044, "SQEX.Ebony.Std.Fixid", 1256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId6_", 3373501139, "SQEX.Ebony.Std.Fixid", 1260, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId7_", 152448554, "SQEX.Ebony.Std.Fixid", 1264, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memoryQuestParamId8_", 151315721, "SQEX.Ebony.Std.Fixid", 1268, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}