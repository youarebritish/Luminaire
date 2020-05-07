using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.WorldMap
{
    public partial class SequenceActionGetWorldMapType : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin NONE_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin LUCHIL_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin TERABELDE_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ALTISSIA_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin MOG_ALTISSIA_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin NOX_EPG_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin NOX_EPP_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin NOX_EPI_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ROUTE_XIII_GLADIO_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin FEATHER_DUSCAE_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin NOX_MULTI_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin GOTY_LAST_DUNGEON_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetWorldMapType();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.WorldMap.SequenceActionGetWorldMapType", 0, Black.Sequence.Action.WorldMap.SequenceActionGetWorldMapType.ObjectType, null, properties, 0, 1424);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.WorldMap.SequenceActionGetWorldMapType", base.GetFieldProperties(), 439827388, 1521971426);
            return fieldProperties;
        }

		
    }
}