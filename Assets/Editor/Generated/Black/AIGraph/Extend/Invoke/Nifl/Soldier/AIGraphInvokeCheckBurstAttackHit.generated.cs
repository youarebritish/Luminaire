using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl.Soldier
{
    public partial class AIGraphInvokeCheckBurstAttackHit : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enable;
		public float canBurstAngle;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeCheckBurstAttackHit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeCheckBurstAttackHit", 0, Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeCheckBurstAttackHit.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeCheckBurstAttackHit", base.GetFieldProperties(), 1291950560, -1887665411);
            return fieldProperties;
        }

		
    }
}