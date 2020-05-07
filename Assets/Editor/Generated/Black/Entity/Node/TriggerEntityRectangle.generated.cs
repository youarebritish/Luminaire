using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class TriggerEntityRectangle : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint eventId_;
		public string eventString_;
		public UnityEngine.Vector4 scaling_;
		public int touchTarget_;
		public int count_;
		public int backCount_;
		public int characterSelectID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TriggerEntityRectangle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.TriggerEntityRectangle", 0, Black.Entity.Node.TriggerEntityRectangle.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.TriggerEntityRectangle", base.GetFieldProperties(), 1764847104, 668050477);
            return fieldProperties;
        }

		
    }
}