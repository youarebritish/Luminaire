using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIMoveOffMeshLink : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Entity.EntityGroup entityPointer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin arrivedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin releaseTurnstilePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin activatedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin oppositeSideActivatedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isActive_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIMoveOffMeshLink();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIMoveOffMeshLink", 0, Black.Sequence.Actor.AI.SequenceActionAIMoveOffMeshLink.ObjectType, null, properties, 0, 904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIMoveOffMeshLink", base.GetFieldProperties(), -1669295898, -501222727);
            
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "SQEX.Ebony.Framework.Entity.EntityGroup", 232, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("arrivedPin_", 214469358, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 240, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("releaseTurnstilePin_", 2070920038, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 336, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("activatedPin_", 473133676, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 432, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("oppositeSideActivatedPin_", 1714636638, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 528, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishedPin_", 1775979791, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 624, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isActive_", 4051442688, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}