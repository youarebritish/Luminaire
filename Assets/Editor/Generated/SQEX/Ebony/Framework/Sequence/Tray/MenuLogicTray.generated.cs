using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Tray
{
    public partial class MenuLogicTray : SQEX.Ebony.Framework.Sequence.Tray.SequenceTray
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MenuLogicTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Tray.MenuLogicTray", 0, SQEX.Ebony.Framework.Sequence.Tray.MenuLogicTray.ObjectType, null, properties, 1, 336);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Tray.MenuLogicTray", base.GetFieldProperties(), -1188443922, -1883148188);
            return fieldProperties;
        }

		
    }
}