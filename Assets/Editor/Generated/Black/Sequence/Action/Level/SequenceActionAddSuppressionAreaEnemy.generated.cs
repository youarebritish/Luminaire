using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionAddSuppressionAreaEnemy : Black.Sequence.Action.Level.SequenceActionSetSuppressionArea
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAddSuppressionAreaEnemy();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionAddSuppressionAreaEnemy", 0, Black.Sequence.Action.Level.SequenceActionAddSuppressionAreaEnemy.ObjectType, null, properties, 0, 912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionAddSuppressionAreaEnemy", base.GetFieldProperties(), -1339079033, 292832458);
            
			
			
			return fieldProperties;
        }

		
    }
}