using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetPositionIndexSwfEntity : Black.Sequence.Action.Menu.SequenceActionSwfEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin indexPin_;
		public int type_;
		public UnityEngine.Vector4 position_;
		public float offsetX_;
		public float offsetY_;
		public int wrapLength_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetPositionIndexSwfEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetPositionIndexSwfEntity", 0, Black.Sequence.Action.Menu.SequenceActionSetPositionIndexSwfEntity.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetPositionIndexSwfEntity", base.GetFieldProperties(), -1057857815, -60120656);
            return fieldProperties;
        }

		
    }
}