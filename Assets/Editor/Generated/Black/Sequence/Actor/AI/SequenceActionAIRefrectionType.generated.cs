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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageAdd_", 1428400564, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageAddAir_", 4119507302, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageSmall_", 1144593784, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageSmallAir_", 2099328146, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageMiddle_", 4235858734, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageMiddleAir_", 1892463352, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageBrow_", 3930568255, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageBrowUp_", 2410593400, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("guard_", 731643939, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("refrect_", 3562679613, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1144, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("unisonCommandEnemy_", 1614205717, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1240, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageOnly_", 909078231, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1336, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}