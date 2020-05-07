using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class PillarHPGaugeMenuEntityEPG : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 offset3d_;
		public UnityEngine.Vector4 offset2d_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PillarHPGaugeMenuEntityEPG();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.PillarHPGaugeMenuEntityEPG", 0, Black.Entity.Menu.PillarHPGaugeMenuEntityEPG.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.PillarHPGaugeMenuEntityEPG", base.GetFieldProperties(), -1430409779, -768291371);
            return fieldProperties;
        }

		
    }
}