using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Tray
{
    public partial class SequenceTrayBase : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Sequence.SequenceNode> nodes_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceTrayBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Tray.SequenceTrayBase", 0, SQEX.Ebony.Framework.Sequence.Tray.SequenceTrayBase.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Tray.SequenceTrayBase", base.GetFieldProperties(), 71106638, 1546088567);
            return fieldProperties;
        }

		
    }
}