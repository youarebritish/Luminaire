using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl.Soldier
{
    public partial class AIGraphInvokeSetFlagSoldierState : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isCallingEnable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetFlagSoldierState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeSetFlagSoldierState", 0, Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeSetFlagSoldierState.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.Soldier.AIGraphInvokeSetFlagSoldierState", base.GetFieldProperties(), -1262252880, 1106061411);
            
			
			
			return fieldProperties;
        }

		
    }
}