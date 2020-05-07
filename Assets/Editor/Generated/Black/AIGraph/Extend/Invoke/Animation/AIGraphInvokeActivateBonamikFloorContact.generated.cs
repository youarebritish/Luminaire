using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Animation
{
    public partial class AIGraphInvokeActivateBonamikFloorContact : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeActivateBonamikFloorContact();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeActivateBonamikFloorContact", 0, Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeActivateBonamikFloorContact.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeActivateBonamikFloorContact", base.GetFieldProperties(), 1308685966, 1571621021);
            
			
			
			return fieldProperties;
        }

		
    }
}