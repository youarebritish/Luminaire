using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.MiniGame.Fishing
{
    public partial class SequenceActionGetFishRadar : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int target_;
		public int cellLength_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetFishRadar();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.MiniGame.Fishing.SequenceActionGetFishRadar", 0, Black.Sequence.Action.MiniGame.Fishing.SequenceActionGetFishRadar.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.MiniGame.Fishing.SequenceActionGetFishRadar", base.GetFieldProperties(), 593177573, -584146369);
            return fieldProperties;
        }

		
    }
}