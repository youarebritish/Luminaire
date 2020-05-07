using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Combat
{
    public partial class AIGraphInvokeReloadAmmo : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int magazineIndex_;
		public int reloadCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeReloadAmmo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeReloadAmmo", 0, Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeReloadAmmo.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeReloadAmmo", base.GetFieldProperties(), 1606303758, -821101273);
            return fieldProperties;
        }

		
    }
}