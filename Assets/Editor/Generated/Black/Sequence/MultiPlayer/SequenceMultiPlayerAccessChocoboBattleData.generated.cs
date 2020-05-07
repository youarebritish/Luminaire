using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerAccessChocoboBattleData : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int mode_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo1set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo2set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo3set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo4set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enemySet_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battleClassId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo1type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo2type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo3type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo4type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy1class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy1ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy2class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy2ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy3class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy3ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy4class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy4ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stPower_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stGil_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stItem_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stItemNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rewardItem_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rewardItemNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerAccessChocoboBattleData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData.ObjectType, null, properties, 0, 2680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData", base.GetFieldProperties(), 474444024, -1558396104);
            
			fieldProperties.AddProperty(new Property("inSet_", 608539611, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inStart_", 3384800707, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inFinish_", 4231451394, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mode_", 2139822391, "Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData.AccessMode", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo1set_", 2161877684, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo2set_", 2523578657, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo3set_", 3087128910, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo4set_", 3028077875, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemySet_", 3089131794, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleClassId_", 2536508089, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo1type_", 1296143030, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo2type_", 3926534113, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo3type_", 1266828168, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chocobo4type_", 4113874059, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy1class_", 2508784995, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy1ow_", 3046127561, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy2class_", 1828521942, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy2ow_", 3241643946, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy3class_", 2480779245, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy3ow_", 1411279147, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy4class_", 3269695592, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemy4ow_", 1814574964, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reward1stPower_", 2570459784, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reward1stGil_", 3705688395, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reward1stItem_", 3569603742, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reward1stItemNum_", 3934298004, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2416, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rewardItem_", 4092627978, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rewardItemNum_", 2141950400, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}