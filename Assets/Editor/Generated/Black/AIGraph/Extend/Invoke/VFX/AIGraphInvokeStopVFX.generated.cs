using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.VFX
{
    public partial class AIGraphInvokeStopVFX : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint vlinkID;
		public int vfxStopType;
		public int WeaponOption;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeStopVFX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokeStopVFX", 0, Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokeStopVFX.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokeStopVFX", base.GetFieldProperties(), -236255206, 1874979613);
            
			
			
			return fieldProperties;
        }

		
    }
}