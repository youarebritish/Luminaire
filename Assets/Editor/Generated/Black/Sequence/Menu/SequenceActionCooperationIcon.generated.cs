using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Menu
{
    public partial class SequenceActionCooperationIcon : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin show_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin hide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCooperationIcon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Menu.SequenceActionCooperationIcon", 0, Black.Sequence.Menu.SequenceActionCooperationIcon.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Menu.SequenceActionCooperationIcon", base.GetFieldProperties(), 502827115, 1738034497);
            return fieldProperties;
        }

		
    }
}