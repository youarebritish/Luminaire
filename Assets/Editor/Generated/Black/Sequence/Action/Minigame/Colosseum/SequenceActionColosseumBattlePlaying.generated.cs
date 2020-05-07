using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumBattlePlaying : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin drawGamePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin supportPlayPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin supportSuspendPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin win_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lose_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin draw_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin support_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin payMedalPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumBattlePlaying();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumBattlePlaying", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumBattlePlaying.ObjectType, null, properties, 0, 1320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumBattlePlaying", base.GetFieldProperties(), -1370029424, 780787514);
            
			
			
			return fieldProperties;
        }

		
    }
}