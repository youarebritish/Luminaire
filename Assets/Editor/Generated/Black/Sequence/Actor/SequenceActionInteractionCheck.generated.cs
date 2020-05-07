using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionInteractionCheck : Black.Sequence.Actor.SequenceActionInteraction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cursor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cursor_camera_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin interactionActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionInteractionCheck();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionInteractionCheck", 0, Black.Sequence.Actor.SequenceActionInteractionCheck.ObjectType, null, properties, 0, 1480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionInteractionCheck", base.GetFieldProperties(), 1125163869, 1265031245);
            
			fieldProperties.AddProperty(new Property("cursor_", 4266734576, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cursor_camera_", 2318028416, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionActor_", 1976265869, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}