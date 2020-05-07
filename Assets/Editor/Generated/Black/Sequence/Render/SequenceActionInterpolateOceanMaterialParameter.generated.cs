using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionInterpolateOceanMaterialParameter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin interpolationTimePin_;
		public float interpolationTime_;
		public IList<Black.Entity.Material.MaterialParameterColor> materialParamColor_;
		public IList<Black.Entity.Material.MaterialParameterValue1> materialParamValue1_;
		public IList<Black.Entity.Material.MaterialParameterValue4> materialParamValue4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionInterpolateOceanMaterialParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionInterpolateOceanMaterialParameter", 0, Black.Sequence.Render.SequenceActionInterpolateOceanMaterialParameter.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionInterpolateOceanMaterialParameter", base.GetFieldProperties(), -1002212364, -1962380178);
            
			
			
			return fieldProperties;
        }

		
    }
}