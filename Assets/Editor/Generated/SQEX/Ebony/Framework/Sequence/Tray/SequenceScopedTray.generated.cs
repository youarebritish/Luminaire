using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Tray
{
    public partial class SequenceScopedTray : SQEX.Ebony.Framework.Sequence.Tray.SequenceTray
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceScopedTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Tray.SequenceScopedTray", 0, SQEX.Ebony.Framework.Sequence.Tray.SequenceScopedTray.ObjectType, null, properties, 1, 264);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Tray.SequenceScopedTray", base.GetFieldProperties(), 856703985, 23182661);
            
			
			
			return fieldProperties;
        }

		
    }
}