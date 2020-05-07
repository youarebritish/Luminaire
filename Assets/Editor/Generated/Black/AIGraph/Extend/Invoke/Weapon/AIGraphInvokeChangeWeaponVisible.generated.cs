using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Weapon
{
    public partial class AIGraphInvokeChangeWeaponVisible : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isVisible_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeChangeWeaponVisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeChangeWeaponVisible", 0, Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeChangeWeaponVisible.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeChangeWeaponVisible", base.GetFieldProperties(), 1663758556, -726826241);
            return fieldProperties;
        }

		
    }
}