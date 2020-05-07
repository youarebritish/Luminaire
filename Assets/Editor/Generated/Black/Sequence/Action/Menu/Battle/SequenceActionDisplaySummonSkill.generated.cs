using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu.Battle
{
    public partial class SequenceActionDisplaySummonSkill : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public int saveSummon_;
		public float displayTimeSec_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDisplaySummonSkill();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.Battle.SequenceActionDisplaySummonSkill", 0, Black.Sequence.Action.Menu.Battle.SequenceActionDisplaySummonSkill.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.Battle.SequenceActionDisplaySummonSkill", base.GetFieldProperties(), 1798901580, 2024972157);
            return fieldProperties;
        }

		
    }
}