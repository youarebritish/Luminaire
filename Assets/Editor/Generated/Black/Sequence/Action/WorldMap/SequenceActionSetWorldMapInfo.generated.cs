using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.WorldMap
{
    public partial class SequenceActionSetWorldMapInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setShiftOffset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin restoreShiftOffset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enableToChange_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool usePlayerPos_;
		public bool isAreaChange_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isAreaChange_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shiftOffsetPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetWorldMapInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.WorldMap.SequenceActionSetWorldMapInfo", 0, Black.Sequence.Action.WorldMap.SequenceActionSetWorldMapInfo.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.WorldMap.SequenceActionSetWorldMapInfo", base.GetFieldProperties(), -2050867022, 589856415);
            return fieldProperties;
        }

		
    }
}