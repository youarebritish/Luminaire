using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl.Soldier
{
    public partial class AIGraphInvokeResetSpear : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeResetSpear();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeResetSpear", 0, Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeResetSpear.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeResetSpear", base.GetFieldProperties(), -1531285527, 1684607757);
            return fieldProperties;
        }

		
    }
}