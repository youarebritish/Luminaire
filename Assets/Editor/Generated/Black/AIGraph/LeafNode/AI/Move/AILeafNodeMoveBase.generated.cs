using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeMoveBase : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum urgency;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum desiredMoveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum maxMoveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveSpeedDetailed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum desiredArrivalSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalMoveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum atLocationRequirement;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isUseLookAtTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum lookAtTargetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt moveReleaseDelay;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt moveMode;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool excludeTargetForAvoidance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum avoidOnIdle;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeMoveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase", base.GetFieldProperties(), 1296649075, 2054740834);
            return fieldProperties;
        }

		
    }
}