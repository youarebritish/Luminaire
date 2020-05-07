using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorRotate : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin minSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin maxSpeed_;
		public UnityEngine.Vector4 maxSpeedVal_;
		public UnityEngine.Vector4 minSpeedVal_;
		public float accelTime_;
		public float accelTimeRandRate_;
		public float constantMaxTime_;
		public float constantMaxTimeRandRate_;
		public float decelTime_;
		public float decelTimeRandRate_;
		public float constantMinTime_;
		public float constantMinTimeRandRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorRotate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorRotate", 0, Black.Sequence.Actor.SequenceActionActorRotate.ObjectType, null, properties, 0, 976);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorRotate", base.GetFieldProperties(), 1491383605, -1547809163);
            
			
			
			return fieldProperties;
        }

		
    }
}