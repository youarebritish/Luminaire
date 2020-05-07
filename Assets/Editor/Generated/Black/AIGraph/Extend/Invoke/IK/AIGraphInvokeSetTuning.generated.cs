using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.IK
{
    public partial class AIGraphInvokeSetTuning : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float blendTime;
		public int ikType;
		public uint tuningSetLabel;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetTuning();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetTuning", 0, Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetTuning.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetTuning", base.GetFieldProperties(), -1530309958, -782863719);
            
			
			
			return fieldProperties;
        }

		
    }
}