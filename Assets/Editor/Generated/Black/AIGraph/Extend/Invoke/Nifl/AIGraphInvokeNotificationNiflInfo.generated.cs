using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl
{
    public partial class AIGraphInvokeNotificationNiflInfo : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int notifyInfoType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeNotificationNiflInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeNotificationNiflInfo", 0, Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeNotificationNiflInfo.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeNotificationNiflInfo", base.GetFieldProperties(), -157360492, 1067207656);
            return fieldProperties;
        }

		
    }
}