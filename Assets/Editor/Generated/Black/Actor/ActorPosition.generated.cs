using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorPosition : Black.Actor.Actor
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float baseScale_;
		public double[] worldPosition_;
		public UnityEngine.Vector4 rotation_;
		public UnityEngine.Vector4 scaling_;
		public Black.Actor.Actor.ConstraintInfo constraintInfo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorPosition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorPosition", 0, Black.Actor.ActorPosition.ObjectType, null, properties, 59, 768);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorPosition", base.GetFieldProperties(), 1292519168, -705325875);
            return fieldProperties;
        }

		
    }
}