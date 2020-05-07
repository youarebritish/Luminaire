using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugCampMenu : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menuExit_;
		public UnityEngine.Vector4 areaPosition_;
		public IList<Black.Sequence.Action.Debug.DebugCampMenuItem> campItemList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugCampMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugCampMenu", 0, Black.Sequence.Action.Debug.SequenceActionDebugCampMenu.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugCampMenu", base.GetFieldProperties(), -1234604547, -507030759);
            return fieldProperties;
        }

		
    }
}