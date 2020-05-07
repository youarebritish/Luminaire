using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class RailMovePointNodeEntityGroup : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint motionId_;
		public float railPathWidth_;
		public bool drawInverseCurve_;
		public UnityEngine.Vector4 tcb_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RailMovePointNodeEntityGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.RailMovePointNodeEntityGroup", 0, Black.Entity.Node.RailMovePointNodeEntityGroup.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.RailMovePointNodeEntityGroup", base.GetFieldProperties(), 1510819898, 198280633);
            
			fieldProperties.AddIndirectlyProperty(new Property("entities_", 798990575, "SQEX.Ebony.Std.IntrusivePointerDynamicArray< SQEX.Ebony.Framework.Entity.Entity >", 64, 16, 1, Property.PrimitiveType.IntrusivePointerArray, 0, (char)5));
			fieldProperties.AddIndirectlyProperty(new Property("hasTransform_", 3096138238, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 112, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canManipulate_", 3989276646, "bool", 132, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("motionId_", 2892861327, "SQEX.Ebony.Std.Fixid", 208, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("railPathWidth_", 814788115, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawInverseCurve_", 231419169, "bool", 216, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("tcb_", 117014939, "Luminous.Math.VectorA", 224, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}