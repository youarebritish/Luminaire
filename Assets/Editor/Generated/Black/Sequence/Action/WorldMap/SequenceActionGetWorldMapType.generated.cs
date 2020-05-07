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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("NONE_", 2402682892, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("LUCHIL_", 2211636097, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("TERABELDE_", 2391446678, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ALTISSIA_", 1785276352, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("MOG_ALTISSIA_", 679100574, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("NOX_EPG_", 602050380, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("NOX_EPP_", 600329167, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("NOX_EPI_", 1675523806, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ROUTE_XIII_GLADIO_", 402047194, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("FEATHER_DUSCAE_", 2351483847, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("NOX_MULTI_", 1095570265, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("GOTY_LAST_DUNGEON_", 2809698209, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1328, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}