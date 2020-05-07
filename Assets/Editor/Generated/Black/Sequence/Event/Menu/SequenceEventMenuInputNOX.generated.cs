using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventMenuInputNOX : Black.Sequence.Event.Menu.SequenceEventMenuInput
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin mapMenuPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cameraLockPin_;
		public bool mapMenuClearPad_;
		public bool cameraLockClearPad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventMenuInputNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventMenuInputNOX", 0, Black.Sequence.Event.Menu.SequenceEventMenuInputNOX.ObjectType, null, properties, 0, 3304);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventMenuInputNOX", base.GetFieldProperties(), -1527116788, -1927687753);
            
			fieldProperties.AddProperty(new Property("mapMenuPin_", 109629238, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraLockPin_", 2079395253, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mapMenuClearPad_", 789695141, "bool", 3296, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraLockClearPad_", 1429937744, "bool", 3297, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}