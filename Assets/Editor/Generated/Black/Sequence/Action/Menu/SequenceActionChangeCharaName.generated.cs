using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionChangeCharaName : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changePinI_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin defaultNamePinI_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPinO_;
		public int selectChara_;
		public uint nameTextId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeCharaName();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionChangeCharaName", 0, Black.Sequence.Action.Menu.SequenceActionChangeCharaName.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionChangeCharaName", base.GetFieldProperties(), -533724695, -152849310);
            return fieldProperties;
        }

		
    }
}