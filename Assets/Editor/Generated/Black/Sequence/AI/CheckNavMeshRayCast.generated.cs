using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.AI
{
    public partial class CheckNavMeshRayCast : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin @in;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin hit;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin through;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outHitDistance;
		public int checkDirBase;
		public float checkDirOffsetAngle;
		public float checkLength;
		public bool isDebugDraw;
		public float debugDrawTimer;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CheckNavMeshRayCast();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.AI.CheckNavMeshRayCast", 0, Black.Sequence.AI.CheckNavMeshRayCast.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.AI.CheckNavMeshRayCast", base.GetFieldProperties(), -76369796, 1867526570);
            
			fieldProperties.AddProperty(new Property("@in", 1094220446, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hit", 47364266, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("through", 4254058618, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("error", 563185489, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outHitDistance", 2161907099, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkDirBase", 2882307467, "Black.Sequence.AI.CheckNavMeshRayCast.RAYCAST_BASE_DIRECTION", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkDirOffsetAngle", 2978613324, "float", 660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkLength", 1777902727, "float", 664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDebugDraw", 3518925898, "bool", 668, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugDrawTimer", 3266330155, "float", 672, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}