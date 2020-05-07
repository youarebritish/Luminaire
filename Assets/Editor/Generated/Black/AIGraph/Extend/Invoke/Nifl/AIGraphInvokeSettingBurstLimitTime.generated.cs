using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl
{
    public partial class AIGraphInvokeSettingBurstLimitTime : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int limitTimeSetteingOption;
		public float remainingTime;
		public float attenuationInteropSpeed;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSettingBurstLimitTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime", 0, Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime", base.GetFieldProperties(), -1275145301, 1786139246);
            return fieldProperties;
        }

		
    }
}