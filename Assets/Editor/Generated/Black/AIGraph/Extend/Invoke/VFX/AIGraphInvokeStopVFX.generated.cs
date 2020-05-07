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
            
			
			
			fieldProperties.AddProperty(new Property("vlinkID", 170686824, "SQEX.Ebony.Std.Fixid", 24, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxStopType", 3155752767, "Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokeStopVFX.VFX_STOP_TYPE", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("WeaponOption", 1785740048, "Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokeStopVFX.WEAPON_VFX_TYPE", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}