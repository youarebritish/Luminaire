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
            return fieldProperties;
        }

		
    }
}