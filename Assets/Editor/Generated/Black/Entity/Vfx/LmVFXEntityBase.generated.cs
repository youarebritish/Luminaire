using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmVFXEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float baseScaling_;
		public bool enabled_;
		public IList<Black.Entity.Parameter.ParameterInt> externalInt_;
		public IList<Black.Entity.Parameter.ParameterFloat> externalFloat_;
		public IList<Black.Entity.Parameter.ParameterVector> externalVector_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVFXEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmVFXEntityBase", 0, Black.Entity.Vfx.LmVFXEntityBase.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmVFXEntityBase", base.GetFieldProperties(), 771960598, -524534967);
            
			
			
			return fieldProperties;
        }

		
    }
}