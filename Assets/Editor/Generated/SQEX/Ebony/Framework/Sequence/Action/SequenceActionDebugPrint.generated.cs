using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionDebugPrint : SQEX.Ebony.Framework.Sequence.Action.SequenceActionDebugPrintBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugPrint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionDebugPrint", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionDebugPrint.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionDebugPrint", base.GetFieldProperties(), -338877386, 707161719);
            return fieldProperties;
        }

		
    }
}