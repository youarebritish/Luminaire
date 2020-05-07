using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetActorsInDynamicBattleArea : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaFixidIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorListIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint teritoryFixId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetActorsInDynamicBattleArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetActorsInDynamicBattleArea", 0, Black.Sequence.Action.Level.SequenceActionSetActorsInDynamicBattleArea.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetActorsInDynamicBattleArea", base.GetFieldProperties(), 1434333984, 794333662);
            
			
			
			return fieldProperties;
        }

		
    }
}