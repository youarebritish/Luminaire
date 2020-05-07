using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Buddy
{
    public partial class AIGraphInvokeSetNoncombatGambit : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isExecutable_;
		public int layerType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetNoncombatGambit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetNoncombatGambit", 0, Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetNoncombatGambit.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetNoncombatGambit", base.GetFieldProperties(), -70914640, 911047762);
            return fieldProperties;
        }

		
    }
}