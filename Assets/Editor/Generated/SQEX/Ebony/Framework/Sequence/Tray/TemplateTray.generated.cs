using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Tray
{
    public partial class TemplateTray : SQEX.Ebony.Framework.Sequence.Tray.ProxyTray
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TemplateTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Tray.TemplateTray", 0, SQEX.Ebony.Framework.Sequence.Tray.TemplateTray.ObjectType, null, properties, 1, 256);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Tray.TemplateTray", base.GetFieldProperties(), 1866763753, 940885419);
            
			
			
			return fieldProperties;
        }

		
    }
}