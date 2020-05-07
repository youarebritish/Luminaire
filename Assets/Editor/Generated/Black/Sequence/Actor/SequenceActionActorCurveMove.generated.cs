using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorCurveMove : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin segment_;
		public float velo_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin entityPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin veloPin_;
		public Entity.WorldMap.TerrainCurveDataEntity entity_;
		public float raycastLength_;
		public UnityEngine.Vector4 offsetA_;
		public UnityEngine.Vector4 offsetB_;
		public bool isLocalCurveData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCurveMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorCurveMove", 0, Black.Sequence.Actor.SequenceActionActorCurveMove.ObjectType, null, properties, 0, 1152);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorCurveMove", base.GetFieldProperties(), -760804580, -338336220);
            
			
			
			return fieldProperties;
        }

		
    }
}