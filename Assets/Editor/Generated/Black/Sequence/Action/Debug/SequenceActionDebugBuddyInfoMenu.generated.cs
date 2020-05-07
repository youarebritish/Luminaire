using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugBuddyInfoMenu : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin end_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqNext_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqPreview_;
		public bool isPlayerControlOff_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugBuddyInfoMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugBuddyInfoMenu", 0, Black.Sequence.Action.Debug.SequenceActionDebugBuddyInfoMenu.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugBuddyInfoMenu", base.GetFieldProperties(), 1355462174, 187443001);
            return fieldProperties;
        }

		
    }
}