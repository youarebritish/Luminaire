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
            return fieldProperties;
        }

		
    }
}