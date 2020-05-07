using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetScrollBarTransformSwfEntity : Black.Sequence.Action.Menu.SequenceActionSwfEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public UnityEngine.Vector4 position_;
		public float regionWidth_;
		public float regionLength_;
		public float itemsNum_;
		public float slotNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scrollPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin itemsNumPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slotNumPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetScrollBarTransformSwfEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetScrollBarTransformSwfEntity", 0, Black.Sequence.Action.Menu.SequenceActionSetScrollBarTransformSwfEntity.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetScrollBarTransformSwfEntity", base.GetFieldProperties(), -1784146732, 877094484);
            return fieldProperties;
        }

		
    }
}