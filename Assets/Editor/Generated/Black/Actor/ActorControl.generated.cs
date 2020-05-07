using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorControl : Black.Actor.ActorAnimatedModel
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float radius_;
		public float height_;
		public float eyeHeight_;
		public float eyeHeightRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorControl", 0, Black.Actor.ActorControl.ObjectType, null, properties, 60, 7152);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorControl", base.GetFieldProperties(), 963296600, 1157335194);
            return fieldProperties;
        }

		
    }
}