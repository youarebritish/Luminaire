using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeWallCoverPoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeWallCoverPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeWallCoverPoint", 0, Black.Actor.Node.ActorNodeWallCoverPoint.ObjectType, null, properties, 59, 928);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeWallCoverPoint", base.GetFieldProperties(), 774348088, -789048660);
            
			fieldProperties.AddIndirectlyProperty(new Property("baseScale_", 776470431, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("worldPosition_", 1278966829, "Black.Actor.Actor.DoubleVector4", 584, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Black.Actor.Actor.VectorA", 624, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "Black.Actor.Actor.VectorA", 640, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("constraintInfo_", 739900775, "Black.Actor.Actor.ConstraintInfo", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			
			
			return fieldProperties;
        }

		
    }
}