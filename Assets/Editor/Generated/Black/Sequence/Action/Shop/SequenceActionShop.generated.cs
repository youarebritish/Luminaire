using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Shop
{
    public partial class SequenceActionShop : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin openIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closeIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin quitIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shopIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin openedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin tradingOPin_;
		public uint shopId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionShop();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Shop.SequenceActionShop", 0, Black.Sequence.Action.Shop.SequenceActionShop.ObjectType, null, properties, 0, 944);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Shop.SequenceActionShop", base.GetFieldProperties(), 1895481347, -667512516);
            return fieldProperties;
        }

		
    }
}