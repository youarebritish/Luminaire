using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetDynamicBattleArea : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaFixidIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicBattleAreaPos_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicBattleAreaObject_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teritoryHeightIn_;
		public float overwriteTeritoryHeight_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint teritoryFixId_;
		public uint battleAreaConditionFixId_;
		public float battleAreaRadius_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetDynamicBattleArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetDynamicBattleArea", 0, Black.Sequence.Action.Level.SequenceActionSetDynamicBattleArea.ObjectType, null, properties, 0, 936);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetDynamicBattleArea", base.GetFieldProperties(), 2004550395, -1357323047);
            return fieldProperties;
        }

		
    }
}