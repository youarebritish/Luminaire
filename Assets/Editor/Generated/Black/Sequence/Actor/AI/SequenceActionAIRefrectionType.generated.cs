using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIRefrectionType : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageAdd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageAddAir_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageSmall_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageSmallAir_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageMiddle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageMiddleAir_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageBrow_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageBrowUp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin guard_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin refrect_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin unisonCommandEnemy_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin damageOnly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIRefrectionType();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIRefrectionType", 0, Black.Sequence.Actor.AI.SequenceActionAIRefrectionType.ObjectType, null, properties, 0, 1432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIRefrectionType", base.GetFieldProperties(), 1863088712, 1553970942);
            
			
			
			return fieldProperties;
        }

		
    }
}