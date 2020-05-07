using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Summon
{
    public partial class SequenceActionStartSummonForce : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeeded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin timeout_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin UCon_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin playerDead_;
		public int summonId_;
		public int summonDirection_;
		public int startSummonStage_;
		public bool isCheckPlayerDead_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionStartSummonForce();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Summon.SequenceActionStartSummonForce", 0, Black.Sequence.Action.Level.Summon.SequenceActionStartSummonForce.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Summon.SequenceActionStartSummonForce", base.GetFieldProperties(), 1747144737, -12398318);
            
			
			
			return fieldProperties;
        }

		
    }
}