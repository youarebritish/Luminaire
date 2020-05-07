using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class TriggerEntity : Black.Entity.Node.TriggerEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int eventType_;
		public string groupName_;
		public bool isNoCheckFirst_;
		public bool isNoCheckAtUCOff_;
		public bool isSetEventModeAtTouch_;
		public int touchKind_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TriggerEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.TriggerEntity", 0, Black.Entity.Node.TriggerEntity.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.TriggerEntity", base.GetFieldProperties(), 1962417490, 495224432);
            return fieldProperties;
        }

		
    }
}