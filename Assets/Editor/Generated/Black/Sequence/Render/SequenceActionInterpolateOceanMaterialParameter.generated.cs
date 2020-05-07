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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpolationTimePin_", 677879436, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpolationTime_", 1019342201, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParamColor_", 3459353649, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterColor* >", 464, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParamValue1_", 636517702, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue1* >", 480, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParamValue4_", 3856878739, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue4* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}