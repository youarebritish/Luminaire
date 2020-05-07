using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.WorldMap
{
    public partial class SequenceActionSetWorldMapFlyMode : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetWorldMapFlyMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.WorldMap.SequenceActionSetWorldMapFlyMode", 0, Black.Sequence.Action.WorldMap.SequenceActionSetWorldMapFlyMode.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.WorldMap.SequenceActionSetWorldMapFlyMode", base.GetFieldProperties(), -137834510, 285565605);
            return fieldProperties;
        }

		
    }
}