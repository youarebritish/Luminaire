using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Tray
{
    public partial class SequenceDevelopingTray : SQEX.Ebony.Framework.Sequence.Tray.SequenceScopedTray
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startDebugPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startReplayPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePins_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceDevelopingTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Tray.SequenceDevelopingTray", 0, Black.Sequence.Tray.SequenceDevelopingTray.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Tray.SequenceDevelopingTray", base.GetFieldProperties(), -1688579127, -284018473);
            
			fieldProperties.AddProperty(new Property("startDebugPin_", 1286317534, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 264, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startReplayPin_", 4178776488, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 360, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valuePins_", 2792121211, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}