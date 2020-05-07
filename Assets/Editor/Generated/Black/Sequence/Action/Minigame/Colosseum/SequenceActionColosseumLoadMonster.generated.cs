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
            
			
			
			return fieldProperties;
        }

		
    }
}