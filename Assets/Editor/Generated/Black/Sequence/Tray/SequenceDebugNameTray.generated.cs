using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Tray
{
    public partial class SequenceDebugNameTray : SQEX.Ebony.Framework.Sequence.Tray.SequenceTray
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string debugName_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceDebugNameTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Tray.SequenceDebugNameTray", 0, Black.Sequence.Tray.SequenceDebugNameTray.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Tray.SequenceDebugNameTray", base.GetFieldProperties(), -1337604035, -1624576292);
            
			
			
			return fieldProperties;
        }

		
    }
}