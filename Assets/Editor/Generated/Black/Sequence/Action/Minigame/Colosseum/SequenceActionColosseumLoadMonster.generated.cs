using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumLoadMonster : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin routeId_D_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin routeId_C_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin routeId_B_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin routeId_A_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_D_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_C_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_B_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_A_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin monsterGroupId_D_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin monsterGroupId_C_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin monsterGroupId_B_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin monsterGroupId_A_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorGroupId_D_List_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorGroupId_C_List_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorGroupId_B_List_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorGroupId_A_List_;
		public uint monsterGroupId_A_;
		public uint monsterGroupId_B_;
		public uint monsterGroupId_C_;
		public uint monsterGroupId_D_;
		public uint routeId_A_;
		public uint routeId_B_;
		public uint routeId_C_;
		public uint routeId_D_;
		public bool playVfx_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumLoadMonster();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumLoadMonster", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumLoadMonster.ObjectType, null, properties, 0, 1912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumLoadMonster", base.GetFieldProperties(), -437075715, -1312989381);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_D_Pin_", 3095625977, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_C_Pin_", 2816437182, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_B_Pin_", 2733353731, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_A_Pin_", 2034043008, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_D_Pin_", 1134484522, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_C_Pin_", 1352678461, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_B_Pin_", 1769696280, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_A_Pin_", 3527875899, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_D_Pin_", 1064809711, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1168, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_C_Pin_", 3646227048, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_B_Pin_", 852711309, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1344, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_A_Pin_", 3788252454, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroupId_D_List_", 199881705, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1520, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroupId_C_List_", 3051267520, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1608, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroupId_B_List_", 3935206847, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroupId_A_List_", 2268410846, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_A_", 3267320630, "SQEX.Ebony.Std.Fixid", 1872, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_B_", 3266879345, "SQEX.Ebony.Std.Fixid", 1876, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_C_", 2193258824, "SQEX.Ebony.Std.Fixid", 1880, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("monsterGroupId_D_", 2192817539, "SQEX.Ebony.Std.Fixid", 1884, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_A_", 2992938672, "SQEX.Ebony.Std.Fixid", 1888, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_B_", 4066853383, "SQEX.Ebony.Std.Fixid", 1892, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_C_", 4067000478, "SQEX.Ebony.Std.Fixid", 1896, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_D_", 4065867645, "SQEX.Ebony.Std.Fixid", 1900, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("playVfx_", 5410882, "bool", 1904, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}