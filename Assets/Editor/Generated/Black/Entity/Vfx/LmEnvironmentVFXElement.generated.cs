using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmEnvironmentVFXElement : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string target_;
		public string path_;
		public float rate_;
		public IList<Black.Entity.Parameter.ParameterInt> externalInt_;
		public IList<Black.Entity.Parameter.ParameterFloat> externalFloat_;
		public IList<Black.Entity.Parameter.ParameterVector> externalVector_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmEnvironmentVFXElement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmEnvironmentVFXElement", 0, Black.Entity.Vfx.LmEnvironmentVFXElement.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmEnvironmentVFXElement", base.GetFieldProperties(), -1572810957, 41920177);
            
			
			
			return fieldProperties;
        }

		
    }
}