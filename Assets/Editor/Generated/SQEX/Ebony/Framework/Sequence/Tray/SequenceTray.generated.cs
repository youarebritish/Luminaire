using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Tray
{
    public partial class SequenceTray : SQEX.Ebony.Framework.Sequence.Tray.SequenceTrayBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Tray.SequenceTray", 0, SQEX.Ebony.Framework.Sequence.Tray.SequenceTray.ObjectType, null, properties, 1, 240);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Tray.SequenceTray", base.GetFieldProperties(), -1116947585, -676346667);
            
			
			
			return fieldProperties;
        }

		
    }
}